import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { books: [], loading: true };
  }

  componentDidMount() {
    this.populateWeatherData();
  }

  static renderBooksTable(books) {

    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Title</th>
            <th>Read</th>
            {/* <th>Temp. (F)</th>
            <th>Summary</th> */}
          </tr>
        </thead>
        <tbody>
          {books.map(book =>
            <tr key={book.id}>
              <td>{book.title}</td>
              <td>{String(book.read)}</td>
              {/* <td>{forecast.temperatureF}</td>
              <td>{forecast.summary}</td> */}
            </tr>
          )}
        </tbody>
      </table>

    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderBooksTable(this.state.books);

    return (
      <div>
        <h1 id="tabelLabel" >Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
        
        {contents}
      </div>
    );
  }

  async populateWeatherData() {
    const response = await fetch('books');
    const data = await response.json();
    this.setState({ books: data, loading: false });

    
  }
}
