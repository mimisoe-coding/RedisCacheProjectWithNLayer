using Microsoft.AspNetCore.Mvc;

namespace RedisCacheProjectWithNLayer.Features.Book
{
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BL_Book _blBook;
        public BookController()
        {
            _blBook = new BL_Book();
        }

        [HttpGet("GetList")]
        public IActionResult Get()
        {
            var bookList = _blBook.GetBooks();
            return Ok(bookList);
        }


        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _blBook.GetBookById(id);
            return Ok(book);
        }

        [HttpPost("Update")]
        public IActionResult Update( BookModel reqModel)
        {
            var isUpdate= _blBook.UpdateBook(reqModel);
            return Ok(isUpdate);
        }

        [HttpPost("Save")]
        public IActionResult Save(BookModel book)
        {
            var isSave = _blBook.AddBook(book);
            return Ok(isSave);
        }
    }
}
