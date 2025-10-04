import React, { useState } from 'react';
import { Link } from 'react-router-dom';

export function NavMenu() {
  const [open, setOpen] = useState(false);

  return (
    <header className="bg-white border-b shadow mb-3">
      <nav className="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
        <div className="flex items-center justify-between h-16">
          <div className="flex items-center">
            <Link to="/" className="text-xl font-semibold text-gray-900">QUALITE</Link>
          </div>

          {/* desktop links */}
          <div className="hidden sm:flex sm:space-x-6">
            <Link to="/" className="text-gray-700 hover:text-gray-900">Acceuil</Link>
            <Link to="/rem" className="text-gray-700 hover:text-gray-900">REM</Link>
            <Link to="/res" className="text-gray-700 hover:text-gray-900">RES</Link>
            <Link to="/multi-grade" className="text-gray-700 hover:text-gray-900">MultiGrade</Link>
            <Link to="/manuel" className="text-gray-700 hover:text-gray-900">Manuel</Link>
            <Link to="/places" className="text-gray-700 hover:text-gray-900">Places</Link>
            <Link to="/new-fpe" className="text-gray-700 hover:text-gray-900">Nouvelle FPE</Link>
          </div>

          {/* mobile menu button */}
          <div className="sm:hidden flex items-center">
            <button
              onClick={() => setOpen(!open)}
              aria-expanded={open}
              aria-label="Toggle navigation"
              className="inline-flex items-center justify-center p-2 rounded-md text-gray-700 hover:text-gray-900 focus:outline-none focus:ring-2 focus:ring-inset focus:ring-indigo-500"
            >
              <svg className="h-6 w-6" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke="currentColor" aria-hidden="true">
                {open ? (
                  <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M6 18L18 6M6 6l12 12" />
                ) : (
                  <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M4 6h16M4 12h16M4 18h16" />
                )}
              </svg>
            </button>
          </div>
        </div>

        {/* mobile links */}
        {open && (
          <div className="sm:hidden mt-2 pb-4">
            <div className="flex flex-col space-y-1">
              <Link to="/" onClick={() => setOpen(false)} className="px-3 py-2 rounded-md text-gray-700 hover:bg-gray-100">Acceuil</Link>
              <Link to="/rem" onClick={() => setOpen(false)} className="px-3 py-2 rounded-md text-gray-700 hover:bg-gray-100">REM</Link>
              <Link to="/res" onClick={() => setOpen(false)} className="px-3 py-2 rounded-md text-gray-700 hover:bg-gray-100">RES</Link>
              <Link to="/multi-grade" onClick={() => setOpen(false)} className="px-3 py-2 rounded-md text-gray-700 hover:bg-gray-100">MultiGrade</Link>
              <Link to="/manuel" onClick={() => setOpen(false)} className="px-3 py-2 rounded-md text-gray-700 hover:bg-gray-100">Manuel</Link>
              <Link to="/places" onClick={() => setOpen(false)} className="px-3 py-2 rounded-md text-gray-700 hover:bg-gray-100">Places</Link>
              <Link to="/new-fpe" onClick={() => setOpen(false)} className="px-3 py-2 rounded-md text-gray-700 hover:bg-gray-100">Nouvelle FPE</Link>
            </div>
          </div>
        )}
      </nav>
    </header>
  );
}
export default NavMenu;
