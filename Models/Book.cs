using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBooks.Models
{
    public class Book
    {   //field that acts as our primary key 
        [Required]
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        //ISBN validation
        [Required]
        [RegularExpression("^([0-9]{3}-[0-9]{10})")]
        public string ISBN { get; set; }
        [Required]
        public string Classification_Category { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
