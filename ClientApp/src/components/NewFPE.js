import React, { useState, useCallback } from 'react';
import axios from 'axios';
import * as XLSX from 'xlsx';

// Expected sheet name groups. Etablissement => sheet named 'A1', Personnel => 'P1'.
const SHEET_MAP = {
  etablissement: ['A1', 'Etablissement', 'A01', 'a1'],
  personnel: ['P1', 'Personnel', 'P01', 'p1'],
  m1: ['M1'],
  e1: ['E1'],
  e4: ['E4'],
  k1: ['K1'],
  g1: ['G1'],
  j1: ['J1'],
  l1: ['L1'],
  model_fpe: ['model_fpe', 'Model_FPE', 'MODELFPE', 'ModefFpe']
};

function findSheet(workbook, names) {
  for (const n of names) {
    if (workbook.Sheets[n]) return workbook.Sheets[n];
  }
  // case-insensitive fallback
  const lower = names.map(x => x.toLowerCase());
  for (const sheetName of workbook.SheetNames) {
    if (lower.includes(sheetName.toLowerCase())) return workbook.Sheets[sheetName];
  }
  return null;
}

function cleanRow(row) {
  // Remove keys that are empty or start with __ or are undefined
  const out = {};
  Object.keys(row).forEach(k => {
    if (!k) return;
    if (k.toString().trim() === '') return;
    if (k.startsWith('__')) return;
    const v = row[k];
    // keep null/0/false/'' if present; if undefined skip
    if (typeof v === 'undefined') return;
    out[k] = v;
  });
  return out;
}

export function NewFPE() {
  const [fileName, setFileName] = useState(null);
  const [sheetsSummary, setSheetsSummary] = useState({});
  const [parsed, setParsed] = useState({});
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);
  const [preparedPayload, setPreparedPayload] = useState(null);
  const [showPreview, setShowPreview] = useState(false);

  const handleFile = useCallback(async (file) => {
    setError(null);
    if (!file) return;
    setFileName(file.name);
    try {
      const data = await file.arrayBuffer();
      const workbook = XLSX.read(data, { type: 'array' });

      const result = {};
      const summary = {};

      // For each expected key, try to find matching sheet
      for (const key of Object.keys(SHEET_MAP)) {
        const sheet = findSheet(workbook, SHEET_MAP[key]);
        if (!sheet) {
          result[key] = [];
          summary[key] = { found: false, rows: 0 };
          continue;
        }
        const rows = XLSX.utils.sheet_to_json(sheet, { defval: null });
        // filter rows and columns: keep only sensible keys
        const cleaned = rows.map(r => cleanRow(r));
        result[key] = cleaned;
        summary[key] = { found: true, rows: cleaned.length };
      }

      // Also include any additional sheets whose names look like M1/E1 etc even if not in map
      // (Already covered by SHEET_MAP)

      setParsed(result);
      setSheetsSummary(summary);
    } catch (err) {
      console.error(err);
      setError('Erreur lors de la lecture du fichier XLSX.');
    }
  }, []);

  const onDrop = useCallback((e) => {
    e.preventDefault();
    const file = e.dataTransfer && e.dataTransfer.files && e.dataTransfer.files[0];
    if (file) handleFile(file);
  }, [handleFile]);

  const onFileChange = useCallback((e) => {
    const file = e.target.files && e.target.files[0];
    if (file) handleFile(file);
  }, [handleFile]);

  // prepare payload locally (previously named sendToServer)
  const preparePayload = useCallback(() => {
    setLoading(true);
    setError(null);
    try {
      const modelName = fileName ? fileName.replace(/\.[^.]+$/, '') : null; // filename without extension
      const payload = {
        etablissement: parsed.etablissement || [],
        personnel: parsed.personnel || [],
        m1: parsed.m1 || [],
        e1: parsed.e1 || [],
        e4: parsed.e4 || [],
        k1: parsed.k1 || [],
        g1: parsed.g1 || [],
        j1: parsed.j1 || [],
        l1: parsed.l1 || [],
        model_fpe: modelName
      };

      setPreparedPayload(payload);
      setSheetsSummary(prev => ({ ...prev, prepared: true }));
    } catch (err) {
      console.error(err);
      setError('Erreur lors de la préparation du payload');
    } finally {
      setLoading(false);
    }
  }, [parsed, fileName]);

  // send prepared payload to server via axios
  const sendToServer = useCallback(async () => {
    if (!preparedPayload) {
      setError('Aucun payload préparé.');
      return;
    }
    setLoading(true);
    setError(null);
    try {
      const response = await axios.post('/qualite/model-fpe', preparedPayload);
      setSheetsSummary(prev => ({ ...prev, posted: true, response: response.data }));
    } catch (err) {
      console.error(err);
      setError(err?.response?.data || err.message || 'Erreur lors de l envoi au serveur');
    } finally {
      setLoading(false);
    }
  }, [preparedPayload]);

  const downloadPayload = useCallback(() => {
    if (!preparedPayload) return;
    const dataStr = JSON.stringify(preparedPayload, null, 2);
    const blob = new Blob([dataStr], { type: 'application/json' });
    const url = URL.createObjectURL(blob);
    const a = document.createElement('a');
    a.href = url;
    a.download = `${preparedPayload.model_fpe || 'model_fpe'}.json`;
    document.body.appendChild(a);
    a.click();
    a.remove();
    URL.revokeObjectURL(url);
  }, [preparedPayload]);

  return (
    <div className="p-6 max-w-5xl mx-auto">
      <header className="mb-6">
        <h2 className="text-3xl font-extrabold text-gray-900">Importer un fichier XLSX</h2>
        <p className="text-gray-600">Déposez un fichier contenant les feuilles A1 (Etablissement), P1 (Personnel) et les feuilles M1, E1, E4, K1, G1, J1, L1. Le nom du fichier sera utilisé comme <span className="font-medium">model_fpe</span>.</p>
      </header>

      <div className="grid grid-cols-1 lg:grid-cols-3 gap-6">
        <div className="lg:col-span-2">
          <div
            onDrop={onDrop}
            onDragOver={(e) => e.preventDefault()}
            className="flex flex-col items-center justify-center border-2 border-dashed border-gray-300 rounded-lg p-8 bg-white hover:shadow">
            <svg className="w-12 h-12 text-indigo-500 mb-3" fill="none" stroke="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg"><path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M7 16V4m0 0L3 8m4-4 4 4m6 8v-8a2 2 0 00-2-2h-3"/></svg>
            <p className="text-gray-700 mb-2">Glissez-déposez votre fichier XLSX ici</p>
            <label className="inline-flex items-center px-4 py-2 bg-indigo-600 text-white rounded cursor-pointer hover:bg-indigo-700">
              <input type="file" accept=".xlsx,.xls" onChange={onFileChange} className="hidden" />
              Choisir un fichier
            </label>
            {fileName && <p className="mt-3 text-sm text-gray-500">Fichier: <span className="font-medium">{fileName}</span></p>}
            {error && <p className="mt-2 text-red-600">{error}</p>}
          </div>

          <div className="mt-6 bg-white rounded-lg shadow p-4">
            <h3 className="text-lg font-medium mb-3">Aperçu des feuilles</h3>
            <div className="grid grid-cols-2 md:grid-cols-3 gap-3">
              {Object.keys(SHEET_MAP).map(k => (
                <div key={k} className="border rounded p-3 bg-gray-50">
                  <div className="flex items-center justify-between">
                    <div className="text-sm font-medium text-gray-700">{k}</div>
                    <div className={`text-xs px-2 py-1 rounded ${sheetsSummary[k]?.found ? 'bg-green-100 text-green-800' : 'bg-yellow-100 text-yellow-800'}`}>
                      {sheetsSummary[k]?.found ? `${sheetsSummary[k].rows} ligne(s)` : 'manquante'}
                    </div>
                  </div>
                </div>
              ))}
            </div>
          </div>
        </div>

        <aside className="hidden lg:block">
          <div className="sticky top-6 space-y-4">
            <div className="bg-white rounded-lg shadow p-4">
              <h4 className="font-medium mb-2">Actions</h4>
              <button
                onClick={preparePayload}
                disabled={loading || !fileName}
                className="w-full mb-2 bg-indigo-600 text-white px-4 py-2 rounded disabled:opacity-50"
              >
                {loading ? 'Préparation...' : 'Préparer le payload'}
              </button>

              <button
                onClick={sendToServer}
                disabled={loading || !preparedPayload}
                className="w-full mb-2 bg-blue-600 text-white px-4 py-2 rounded disabled:opacity-50"
              >
                {loading ? 'Envoi...' : 'Envoyer au serveur'}
              </button>

              <button
                onClick={downloadPayload}
                disabled={!preparedPayload}
                className="w-full mb-2 bg-green-600 text-white px-4 py-2 rounded disabled:opacity-50"
              >
                Télécharger JSON
              </button>

              <button
                onClick={() => setShowPreview(s => !s)}
                className="w-full bg-gray-100 text-gray-800 px-4 py-2 rounded"
              >
                {showPreview ? 'Cacher l\'aperçu' : 'Afficher l\'aperçu'}
              </button>
            </div>

            <div className="bg-white rounded-lg shadow p-4">
              <h4 className="font-medium">Statut</h4>
              <p className="text-sm text-gray-600">{preparedPayload ? 'Payload prêt' : 'Aucun payload préparé'}</p>
              {preparedPayload && <p className="mt-2 text-xs text-gray-500">model_fpe: <span className="font-medium">{preparedPayload.model_fpe}</span></p>}
            </div>
          </div>
        </aside>
      </div>

      <div className="mt-6">
        <div className={`bg-white rounded-lg shadow p-4 ${showPreview ? '' : 'hidden'}`}>
          <h3 className="font-medium mb-2">Données parsées (extrait)</h3>
          <pre className="whitespace-pre-wrap max-h-96 overflow-auto bg-gray-50 p-3 rounded">
            {JSON.stringify(parsed, null, 2)}
          </pre>
        </div>
      </div>
    </div>
  );
}
