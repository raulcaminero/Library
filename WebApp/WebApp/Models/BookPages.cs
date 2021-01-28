using System.ComponentModel.DataAnnotations;

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
