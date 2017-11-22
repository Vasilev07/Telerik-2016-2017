/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [],
			categories = [],
			titles = [],
			isbns = [];

		function listBooks(obj) {
			if (!!obj) {
				var result = books.filter(function(book) {
					return book.category === obj.category;
				});
				return result;
			}
			return books;
		}

		function addBook(book) {
			var id;
			if (!book.title || !book.isbn || !book.author || !book.category) {
				throw new Error('Invalid input parameters');
			}
			if (book.title.length < 2 || book.title.length > 100) {
				throw new Error('Book title name must be between 2 and 100 characters');
			}
			if (titles.indexOf(book.title) !== -1) {
				throw new Error('Duplicate title name');
			}
			if (isNaN(book.isbn) || !(book.isbn.toString().length === 10 || book.isbn.toString().length === 13) || isbns.indexOf(book.isbn) !== -1) {
				throw new Error('Invalid ISBN number')
			}
			if (book.author === '') {
				throw new Error('Author name must be non-empty string');
			}
			if (book.category.length < 2 || book.category.length > 100) {
				throw new Error('Book category name must be between 2 and 100 characters');
			}
			book.ID = books.length + 2;
			titles.push(book.title);
			isbns.push(book.isbn);

			if (categories.indexOf(book.category) === -1) {
				categories.push(book.category);
			}

			books.push(book);
			return book;
		}

		function listCategories() {

			return categories;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());

	return library;


}
solve();

module.exports = solve;