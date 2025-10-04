import React, { Component } from 'react';
import axios from 'axios';
// import sheetjs from 'sheetjs';
// // body obj na {} na [] na les 2 cela depend des valeurs de retour du sheetJS
// // mais peut importe vue que soi c'est { {}, {} } soi c'est { [], [] }
//  const Etablissement ={
//     codeEtab: 1
// }
//  const Personnel ={
//     codeEtab: 1
// }
//  const M1 ={
//     codeEtab: 1
// }
//  const E1 ={
//     codeEtab: 1
// }
//  const E4 ={
//     codeEtab: 1
// }
//  const K1 ={
//     codeEtab: 1
// }
//  const G1 ={
//     codeEtab: 1
// }
//  const J1 ={
//     codeEtab: 1
// }
//  const L1 ={
//     codeEtab: 1
// }
//  const ModefFpe ={
//     codeEtab: 1
// }

export class NewFPE extends Component {
  static displayName = NewFPE.name;

  constructor(props) {
    super(props);
    this.state = { forecasts: [], loading: true };
  }

  componentDidMount() {
    // this.populateWeatherData();
  }

  static renderForecastsTable(forecasts) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Date</th>
            <th>Temp. (C)</th>
            <th>Temp. (F)</th>
            <th>Summary</th>
          </tr>
        </thead>
        <tbody>
          {forecasts.map(forecast =>
            <tr key={forecast.date}>
              <td>{forecast.date}</td>
              <td>{forecast.temperatureC}</td>
              <td>{forecast.temperatureF}</td>
              <td>{forecast.summary}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : NewFPE.renderForecastsTable(this.state.forecasts);

    return (
      <div>
        <h1 id="tabelLabel" >Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateWeatherData() {
    // const postBody = JSON.stringify({
    //   etablissement: Etablissement,
    //   personnel: Personnel,
    //   m1: M1,
    //   e1: E1,
    //   e4: E4,
    //   k1: K1,
    //   g1: G1,
    //   j1: J1,
    //   l1: L1,
    //   model_fpe: ModefFpe
    // });
    const response = await axios.post('qualite/model-fpe');
    this.setState({ forecasts: response.data, loading: false });
  }
}
