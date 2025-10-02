import React, { Component } from 'react';

export class MultiGrade extends Component {
  static displayName = MultiGrade.name;

  render() {
    return (
      <>
      <div class='row'>
        <h1 class='h1'>Elèves en classe multigrade</h1>
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
