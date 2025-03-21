namespace RedisCacheProjectWithNLayer.Features.Book;

public class DA_Book
{
    private readonly AppDbContext _context;
    public DA_Book()
    {
        _context = new AppDbContext();
    }

    public List<BookModel> GetBooks()
    {
        return _context.Books.ToList();
    }

    public BookModel GetBookById(int id)
    {
        var book = _context.Books.Find(id);
        return book;
    }

    public int AddBook(BookModel book)
    {
        _context.Books.Add(book);
       return _context.SaveChanges();
    }

    public int UpdateBook(BookModel reqModel)
    {
        var book = _context.Books.Find(reqModel.BookId);
        if(book == null)
            return 0;
        book.BookAuthor = reqModel.BookAuthor;
        book.BookName = reqModel.BookName;
        _context.Books.Update(book);
        return _context.SaveChanges();
    }
}
