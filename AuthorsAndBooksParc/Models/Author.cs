﻿using System.ComponentModel.DataAnnotations;

namespace AuthorsAndBooksParc.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
