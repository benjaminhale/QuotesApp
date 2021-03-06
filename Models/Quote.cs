using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//This is where the fields for the database are specified

namespace QuotesApp.Models
{
    public class Quote
    {
        [Key]
        [Required]
        public int QuoteID { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Citation { get; set; }

    }
}
