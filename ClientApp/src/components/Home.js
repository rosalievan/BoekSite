import React, { useState, useEffect } from 'react';
import Toggle from 'react-toggle'
import "react-toggle/style.css";

export const Home = (props) => {
  const [ books, setBooks] = useState([])
  const [ loading, setLoading] = useState(true)
  const [ selectedBookId, setSelectedBookId] = useState(null)

  async function populateBookData() {
    const response = await fetch('books');
    const data = await response.json();
    setBooks(data)
    setLoading(false)
  }

  useEffect(function () {
    populateBookData();
  }, [])

  function handleCardClick(id){
    if (id == selectedBookId){ 
      setSelectedBookId(null)
    }
    else{
    setSelectedBookId(id)
    }
  };

  function toggleReadStatus(id)
  {
    fetch("books", {  
      method: "PATCH",  
      headers: {"Content-type": "application/json"},  
      body: JSON.stringify({bookId: id})
    })
  }

  function renderBooksTable(books){
    return (
      <div>
        <div className = 'filters'>
          blah
        </div>
      
        <div className='card-feed'>
          {books.map(book =>
            <div className = {`card-div read-${book.read} rating-${book.rating}`} >
              <p className = 'card-title'>{book.title}</p>
              <p className = 'card-author'> Donna Tartt </p>

              <button className={`card-toggle-button ${book.id===selectedBookId ? "card-edit-field--revealed" : ""}`} onClick={() => handleCardClick(book.id)}>^</button>
              
              {book.id === selectedBookId ? 
              <div className = 'card-forms'> 
                <label>
                  <Toggle
                    defaultChecked = {book.read}
                    onChange = {toggleReadStatus(book.id)}/>
                  <span>Read</span>
                </label>
                <p>{selectedBookId}</p>
                <p>{String(book.rating)}</p>
                <p>{String(book.available)}</p>
                <p>+</p></div> : null }
            </div>
          )}
        </div>

        </div>

    );
  }

  let contents = loading
    ? <p><em>Loading...</em></p>
    : renderBooksTable(books);

  return (
    <div>       
      {contents}
    </div>
  );
}
