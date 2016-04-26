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

        var books = [];
        var categories = [];

        function listBooks() {
            var result=[];

            if (!(arguments.length)) {
                return books;
            }
            else if (arguments.length === 1) {

                for (prop in arguments[0]) {

                    result = filterBooks(books, prop, arguments[0][prop]);
                }
            }

            function filterBooks(booksArr, key, value) {

                return booksArr.filter(function (book) {
                    return book[key] === value;
                });
            }

            return result;
        }

        function addBook(book) {
            book.ID = books.length + 1;

            var checkDuplicatingBooks = books.some(function (bookInArr) {
                return bookInArr.title === book.title || bookInArr.isbn === book.isbn
            });

            if (checkDuplicatingBooks) {
                throw new Error();
            }
            if (book.title.length < 2 || book.title.length > 100) {
                throw new Error();
            }
            if (book.category.length < 2 || book.category.length > 100) {
                throw new Error();
            }
            if (book.isbn.length < 10 || book.isbn.length > 13) {
                throw new Error();
            }
            books.push(book);
            return book;
        }

        function listCategories() {
            if (books.length<=0) {
                return [];
            }
            var equal=true,
                temp=books[0].category;
            books.forEach(function(item){
                if (item.category!=temp)
                {
                    equal=false;
                }
                });
            if(equal){
                return [temp];
            }

            books.forEach(function (book) {

                var categoryToAdd = book.category;

                if (!categories.some(function (cat) {
                        return cat === categoryToAdd
                    })) {
                    categories.push(book.category);
                }
            });

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
    }());
    return library;
}
module.exports = solve;

