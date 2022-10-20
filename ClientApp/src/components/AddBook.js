import React, { Component } from 'react';

export class AddBook extends Component {
  static displayName = AddBook.name;

  constructor(props) {
    super(props);
    this.state = {
      books: []
    };
  }

  render() {
    return (
      <div>
        <h1>Add Book</h1>

      </div>
    );
  }
}
