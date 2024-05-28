using System.ComponentModel.DataAnnotations;

namespace CrudNet8MVC.Models
{
    public class Contacto
    {
        //Get y set para indicar que se puede escribir y leer del atributo
        //Si se agrega [Key] se indica una llave primaria, a menos que se use el Id
        [Key]
        public int Id { get; set; }
        //Hace que sea obligatorio

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio")]
        public String Telefono { get; set; }

        [Required(ErrorMessage = "El celular es obligatorio")]
        public String Celular { get; set; }
        [Required(ErrorMessage = "El email es obligatorio")]
        public String Email { get; set; }
        public DateTime FechaCreacion { get; set; }


    }
}
