import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
      <div class='row'>
        <div class="col-9">
          <p>Hello</p>
        </div>
        <div class="col-3">
          <p>World</p>
        </div>
      </div>
    );
  }
}
