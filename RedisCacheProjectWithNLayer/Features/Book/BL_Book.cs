namespace RedisCacheProjectWithNLayer.Features.Book
{
    public class BL_Book
    {
        private readonly DA_Book _daBook;
        public BL_Book()
        {
            _daBook = new DA_Book();
        }

        public List<BookModel> GetBooks()
        {
            return _daBook.GetBooks();
        }

        public BookModel GetBookById(int id)
        {
            return _daBook.GetBookById(id);
        }

        public int AddBook(BookModel book)
        {
            return _daBook.AddBook(book);
        }

        public int UpdateBook(BookModel reqModel)
        {
            return _daBook.UpdateBook(reqModel);
        }
    }
}
