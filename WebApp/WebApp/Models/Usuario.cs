using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Usuario 
    {
        [Key]
        [DisplayName("Codigo")]
        public int codigo { set; get; }

        [Display(Name = "Nombre:")]
        public string primer_nombre { set; get; }


        [Display(Name = "Correo")]
        public string Email { set; get; }

        [DisplayName("Contraseña")]
        public string contrasena { get; set; }


        [Display(Name = "Segudo Nombre")]
        public string segundo_nombre { set; get; }

        [Display(Name = "Apellido")]
        public string primer_apellido { set; get; }

        [Display(Name = "Segundo Apellido")]
        public string segundo_apellido { set; get; }

        public string tipo_identificacion { set; get; }
        public string TipoIdentificacion => tipo_identificacion == "C" ? "Cédula" : "Pasaporte";

        [Display(Name = "Identificación")]
        public string identificacion { set; get; }

        [Display(Name = "Sexo")]
        public string sexo { set; get; }
        public string Sexo => sexo == "M" ? "Masculino" : "Femenino";

        [MaxLength(30)]
        public string contacto { get; set; }

        [MaxLength(50)]
        public string nacionalidad { get; set; }

        public DateTime? fecha_nacimiento { get; set; }
        public string? RutaFoto { set; get; }
        public string EstadoId { set; get; }
        public virtual Estado Estado { get; set; }

        [NotMapped]
        public string NombreCompleto
        {
            get { return primer_nombre.Trim() + " " + primer_apellido; }
        }
        public override string ToString() => Email;
	}
}
