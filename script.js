$(document).ready(() => {
    let booksLoaded = 0;
    const booksPerLoad = 6;
    let allBooks = [];
    let filteredBooks = [];

    function loadBooks() {
        $.ajax({
            url: 'books.json',
            method: 'GET',
            dataType: 'json',
            success: function (data) {
                allBooks = data;
                filteredBooks = allBooks;
                displayBooks();
            },
            error: function (error) {
                console.log("Error: " + error);
            }
        });
    }

    function displayBooks() {
        let bookContainer = $("#books-container");
        let booksToDisplay = filteredBooks.slice(booksLoaded, booksLoaded + booksPerLoad);

        if (booksLoaded === 0 && bookContainer.children().length === 0) {
            bookContainer.empty();
        }

        booksToDisplay.map(book => {
            let bookItem = `
                <div class="book-item">
                    <img src="${book.image}" alt="${book.title}" class="book-image">
                    <h3>${book.title}</h3>
                    <p>Author: ${book.author}</p>
                    <p>Price: ${book.price}</p>
                    <p>${book.description}</p>
                    <button class="main-button-style">Add to Cart</button>
                </div>
            `;
            bookContainer.append(bookItem);
        });

        booksLoaded += booksToDisplay.length

        if (booksLoaded >= filteredBooks.length) {
            $('#load-more-button').hide()
        } else {
            $('#load-more-button').show()
        }
    }

    $("#load-books").click(() => {
        displayBooks();
    });

    // function searchBooks(query) {
    //     filteredBooks = allBooks.filter(book =>
    //         book.title.toLowerCase().includes(query) ||
    //         book.author.toLowerCase().includes(query)
    //     );
    //     booksLoaded = 0
    //     displayBooks()
    // }

    // $('#book-search-input').on('input', function () {
    //     const query = $(this).val().toLowerCase()
    //     searchBooks(query)
    // })

    loadBooks()
});
