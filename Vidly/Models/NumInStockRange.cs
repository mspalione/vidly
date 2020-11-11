using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class NumInStockRange : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie) validationContext.ObjectInstance;
            var errorMessage = "The field Number in Stock must be between 1 and 20.";
            var result = (movie.NumberInStock >= 1 && movie.NumberInStock <= 20)
                ? ValidationResult.Success
                : new ValidationResult(errorMessage);

            return result;
        }
    }
}