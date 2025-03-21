using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedisCacheProjectWithNLayer.Models
{
    [Table("Tbl_Book")]
    public class BookModel
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
    }
}
