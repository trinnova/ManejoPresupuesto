﻿using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Validaciones
{
    // Control + . (punto) : importa namespaces o librerías para que no arroje errores
    public class PrimeraLetraMayusculaAtributte: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty( value.ToString() ) )
            {
                return ValidationResult.Success;
            }

            var primeraLetra = value.ToString()[0].ToString();

            if (primeraLetra != primeraLetra.ToUpper())
            {
                return new ValidationResult("La primera letra debe ser mayúscula");
            }

            return ValidationResult.Success;
        }
    }
}
