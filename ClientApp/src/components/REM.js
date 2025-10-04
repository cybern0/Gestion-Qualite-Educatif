import React, { Component } from 'react';
import axios from 'axios';

export class REM extends Component {
  static displayName = REM.name;

  constructor(props) {
    super(props);
    this.state = { etablissements: [], loading: true, searchCisco: '', searchNomEtab: '', lastError: null };
  }

  // componentDidMount est herité de la class Component, ex: _ready()
  componentDidMount() {
    this.fetchEtabData();
  }

  static renderetablissementsTable(etablissements) {
    if (!etablissements || etablissements.length === 0) return <div>Aucune donnée disponible</div>;
    const sample = etablissements.slice(0, 10);
    const keysSet = new Set();
    sample.forEach(r => Object.keys(r || {}).forEach(k => keysSet.add(k)));
    const keys = Array.from(keysSet);
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>{keys.map(k => <th key={k}>{k}</th>)}</tr>
        </thead>
        <tbody>
          {etablissements.map((etab, idx) => (
            <tr key={etab.CODE_ETAB || etab.code || idx}>
              {keys.map(key => <td key={key}>{(etab && typeof etab[key] !== 'undefined') ? String(etab[key]) : ''}</td>)}
            </tr>
          ))}
        </tbody>
      </table>
    );
  }

  render() {
    
    let contents = this.state.loading ? <p><em>Loading...</em></p> : REM.renderetablissementsTable(this.state.etablissements);
    return (
      <>
      <div className='row'>
        <h1 className='h1'>REM — Indicateurs</h1>
      </div>
      <div className='row mb-4'>
        <div className='col-9'>
          <div className='card p-3'>
            <div className='mb-3 d-flex'>
              <input className='form-control me-2' value={this.state.searchCisco} onChange={e => this.setState({ searchCisco: e.target.value })} placeholder='CISCO (code)' />
              <button className='btn btn-outline-primary me-2' onClick={() => this.fetchByCisco()} disabled={!this.state.searchCisco}>Rechercher</button>
              <input className='form-control me-2' value={this.state.searchNomEtab} onChange={e => this.setState({ searchNomEtab: e.target.value })} placeholder='Nom établissement' />
              <button className='btn btn-outline-success' onClick={() => this.fetchByEtab()} disabled={!this.state.searchNomEtab}>Rechercher</button>
            </div>

            {this.state.lastError && <div className='alert alert-danger'>{this.state.lastError}</div>}

            <div className='mt-3'>{contents}</div>
          </div>
        </div>
        <div className='col-3'>
          <div className='card p-3'>
            <h5>Informations</h5>
            <p>Nombre: <strong>{this.state.etablissements.length}</strong></p>
            <p>Chargement: {this.state.loading ? 'oui' : 'non'}</p>
          </div>
        </div>
      </div>
      </>
    );
  }
  
  async fetchEtabData() {
    this.setState({ loading: true, lastError: null });
    try {
      const response = await axios.get('qualite/rem');
      this.setState({ etablissements: response.data || [], loading: false });
    } catch (err) {
      console.error(err);
      this.setState({ etablissements: [], loading: false, lastError: err?.message || 'Erreur réseau' });
    }
  }

  async fetchByCisco() {
    const code = this.state.searchCisco; if (!code) return;
    this.setState({ loading: true, lastError: null });
    try {
      const response = await axios.get(`qualite/rem?cisco=${encodeURIComponent(code)}`);
      this.setState({ etablissements: response.data || [], loading: false });
    } catch (err) {
      console.error(err);
      this.setState({ etablissements: [], loading: false, lastError: err?.message || 'Erreur réseau' });
    }
  }

  async fetchByEtab() {
    const name = this.state.searchNomEtab; if (!name) return;
    this.setState({ loading: true, lastError: null });
    try {
      const response = await axios.get(`qualite/rem?nomEtab=${encodeURIComponent(name)}`);
      this.setState({ etablissements: response.data || [], loading: false });
    } catch (err) {
      console.error(err);
      this.setState({ etablissements: [], loading: false, lastError: err?.message || 'Erreur réseau' });
    }
  }
}
