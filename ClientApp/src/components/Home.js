import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
      <>
      <div class='row'>
        <h1 class='h1'>Taux de réussite aux examens</h1>
      </div>
      <div class='row'>
        <div class="col-9">
           <table>
              <tr>
                <th>Company</th>
                <th>Contact</th>
                <th>Country</th>
              </tr>
              <tr>
                <td>Alfreds Futterkiste</td>
                <td>Maria Anders</td>
                <td>Germany</td>
              </tr>
              <tr>
                <td>Centro comercial Moctezuma</td>
                <td>Francisco Chang</td>
                <td>Mexico</td>
              </tr>
            </table> 
        </div>
        <div class="col-3">
          <p>World</p>
        </div>
        </div>
      </>
    );
  }
}
