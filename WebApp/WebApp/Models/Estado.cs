using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Usuario = new HashSet<Usuario>();
        }
        public string EstadoId { get; set; }
        public string EstadoNombre { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
