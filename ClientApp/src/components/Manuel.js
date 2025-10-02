import React, { Component } from 'react';

export class Manuel extends Component {
  static displayName = Manuel.name;

  render() {
    return (
      <>
      <div class='row'>
        <h1 class='h1'>Nombre de manuels/élève</h1>
      </div>
      <div class='row'>
        <div class="col-9">
          <p>Hello</p>
        </div>
        <div class="col-3">
          <p>World</p>
        </div>
        </div>
      </>
    );
  }
}
