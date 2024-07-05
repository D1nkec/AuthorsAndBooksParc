using System.ComponentModel.DataAnnotations;

namespace AuthorsAndBooksParc.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Published { get; set; }

        public Author Author { get; set; }

    }
}
