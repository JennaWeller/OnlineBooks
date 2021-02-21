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
        public string AuthorFirstName { get; set; }

        [Required]
        public string AuthorLastName { get; set; }
        [Required]
        public string Publisher { get; set; }
        //ISBN validation
        [Required]
        [RegularExpression("(^[0-9]{3}-[0-9]{10}$)", ErrorMessage = "Please input a valid ISBN number like ###-##########")]
        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        //only accept currency for price 
        [Required]
        [DataType(DataType.Currency, ErrorMessage = "Monetary values only")]
        public double Price { get; set; }
        public int PageNumber { get; set; }
    }
}
