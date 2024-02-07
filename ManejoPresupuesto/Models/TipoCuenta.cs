using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }
        /* Required(ErrorMessage = "El Nombre es obligatorio.")] */

        /* {0}: hace referencia al campo de Nombre, por lo que en esa posición pone el nombre del campo */
        [Required(ErrorMessage = "El {0} es obligatorio.")]
        [StringLength(maximumLength:50, MinimumLength =3, ErrorMessage ="Carácteres permitidos de: {2} a: {1}")]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }
    }
}
