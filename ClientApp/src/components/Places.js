import React, { Component } from 'react';

export class Places extends Component {
  static displayName = Places.name;

  render() {
    return (
      <>
      <div class='row'>
        <h1 class='h1'>Nombre d’élèves/Place assise</h1>
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
