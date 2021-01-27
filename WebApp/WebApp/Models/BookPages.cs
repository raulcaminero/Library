using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class BookPages
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Text { get; set; }
        public int Page { get; set; }
        public virtual Book Book { get; set; }


    }
}
