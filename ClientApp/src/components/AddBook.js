import React, { Component } from 'react';

export class AddBook extends Component {
  static displayName = AddBook.name;

  // constructor(props) {
  //   super(props);
  //   this.state = { currentCount: 0 };
  //   this.incrementCounter = this.incrementCounter.bind(this);
  // }

  constructor(props) {
    super(props);
    this.state = {
      books: []
    };
  }

  // incrementCounter() {
  //   this.setState({
  //     currentCount: this.state.currentCount + 1
  //   });
  // }



  render() {
    return (
      <div>
        <h1>Counter</h1>

        {/* <p>This is a simple example of a React component.</p>
        {this.props.books.map((book, i) => {     
           console.log("Entered");                      
           return (<Book key={i} answer={book} />) 
        })} */}
  
        {/* <p aria-live="polite">Current count: <strong>{this.state.currentCount}</strong></p> */}

        {/* <button className="btn btn-primary" onClick={this.incrementCounter}>Increment</button> */}
      </div>
    );
  }
}
