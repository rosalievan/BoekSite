import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  constructor(props) {
    super(props);
    this.state = { books: [], loading: true };
  }

  componentDidMount() {
    this.populateBookData();
  }

  static renderBooksTable(books) {

    return (
      
        <div className='card-feed'>
          {books.map(book =>
            <div className = {`card-div read-${book.read} rating-${book.rating}`} >
              <p className = 'card-title'>{book.title}</p>
              <p className = 'card-author'> Donna Tartt </p>
              <div className = 'card-forms'> 
                <p>{String(book.read)}</p>
                <p>{String(book.rating)}</p>
                <p>{String(book.available)}</p>
                <p>+</p></div>
            </div>
          )}
        </div>

    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Home.renderBooksTable(this.state.books);

    return (
      <div>
        <h1 id="tabelLabel" >Books</h1>
        <p>This component demonstrates fetching data from the server.</p>
        
        {contents}
      </div>
    );
  }

  async populateBookData() {
    const response = await fetch('books');
    const data = await response.json();
    this.setState({ books: data, loading: false });
}

}
