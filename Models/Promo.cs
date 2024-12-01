using MABurger2.Models;

namespace MABurger2.Models
{
    public class Promo
    {
        public int Promoid { get; set; }
        public string? Description { get; set; }
        public DateTime FechaPromo { get; set; }
        public int BurgerID { get; set; }
        public Burger? Burger { get; set; }
    }
}
