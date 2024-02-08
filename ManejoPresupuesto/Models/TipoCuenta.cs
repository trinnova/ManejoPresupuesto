using ManejoPresupuesto.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class TipoCuenta //: IValidatableObject
    {
        public int Id { get; set; }
        // Required(ErrorMessage = "El Nombre es obligatorio.")]

        // {0}: hace referencia al campo de Nombre, por lo que en esa posición pone el nombre del campo
        [Required(ErrorMessage = "El {0} es obligatorio.")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "Carácteres permitidos de: {2} a: {1}")]
        
        // Al quitar el nombre del campo de Label, con Display podemos asignar el nombre
        [Display(Name = "Nombre del Tipo de Cuenta")]
        [PrimeraLetraMayusculaAtributte]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Nombre != null && Nombre.Length > 0)
        //    {
        //        var primeraLetra = Nombre[0].ToString();

        //        if (primeraLetra != primeraLetra.ToUpper())
        //        {
        //            yield return new ValidationResult("La primera letra debe ser mayúscula",
        //                new[] { nameof(Nombre) });
        //        }
        //    }
        //}

        // Otras pruebas de validación
        //[Required(ErrorMessage = "El campo: {0} es requerido")]
        //[EmailAddress(ErrorMessage = "El campo debe ser un correo electrónico")]
        //public string Email { get; set; }

        //[Range(minimum: 18, maximum: 65, ErrorMessage = "La edad debe ser entre: {1} y: {2}")]
        //public int Edad { get; set; }

        //[Url(ErrorMessage = "El campo debe ser una URL válida")]
        //public string URL { get; set; }

        //[CreditCard(ErrorMessage = "La tarjeta de crédito NO es válida")]
        //[Display(Name = "Tarjeta de Crédito")]
        //public string TarjetaCredito { get; set; }
    }
}
