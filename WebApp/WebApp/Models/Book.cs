using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        //[DisplayName("Titulo")]
        //[Remote(action: "CheckExisting_Code", controller: "Carreras", AdditionalFields = "Id")]
        [Required(ErrorMessage = "Es necesario introducir un titulo para el libro")]
        public string Title { get; set; }
        public string Author { get; set; }
        public virtual ICollection<BookPages> BookPages { get; set; }

    }
}
