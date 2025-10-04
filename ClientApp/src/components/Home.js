import React, { Component } from 'react';
import axios from 'axios';

export class Home extends Component {
  static displayName = Home.name;

  constructor(props) {
    super(props);
    this.state = { etablissements: [], loading: true };
  }

  // componentDidMount est herité de la class Component, ex: _ready()
  componentDidMount() {
    // this.fetchEtabData();
  }

  static renderetablissementsTable(etablissements) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>CODE_ETAB</th>
            <th>ETABLISSEMENT</th>
            {/* <th>Taux de réussite aux examens</th>
            <th>Ratio Elève/Maître </th>
            <th>Ratio Elève/Salle </th>
            <th>% d’Elèves en classe multigrade </th>
            <th>Nombre de manuels/élève</th>
            <th>Nombre d’élèves/Place assise</th> */}
          </tr>
        </thead>
        <tbody>
          {etablissements.map(etab =>
            <tr key={etab.codeTypeSexe}>
              <td>{etab.codeTypeSexe}</td>
              <td>{etab.typeSexe}</td>
              {/* <td>{etab.examen}</td>
              <td>{etab.rem}</td>
              <td>{etab.res}</td>
              <td>{etab.multi_grade}</td>
              <td>{etab.manuel}</td>
              <td>{etab.places}</td> */}
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    
    let contents = this.state.loading ? 
      <p><em>Loading...</em></p> : 
        Home.renderetablissementsTable(this.state.etablissements);
    return (
      <>
      <div class='row'>
        <h1 class='h1'>Taux de réussite aux examens</h1>
      </div>
      <div class='row'>
        <div class="col-9">
          {contents}  
        </div>
        <div class="col-3">
          <p>World</p>
        </div>
      </div>
      </>
    );
  }
  
  async fetchEtabData() {
        const response = await axios.get('qualite');
        if (response.status === 200) {
          this.setState({ etablissements: response.data, loading: false });
        } else {
          this.setState({ etablissements: [], loading: false });
        }
  }
}
