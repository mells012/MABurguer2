using System.ComponentModel.DataAnnotations;
using MABurger2.Models;

namespace MABurger2.Models {
    
    public class Burger
    {
        public int BurgerID { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [VerificandoRango]
        public decimal Price { get; set; }
    
        public List<Promo>? Promos { get; set; }
    }

    public class VerificandoRango : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            decimal valor = (decimal)value;
            if (valor < 1 || valor > 30)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}