using System.ComponentModel.DataAnnotations;

namespace OrderBookExample
{
    public enum OrderSide
    {
        [Display(Name = "Buy")]
        buy,
        [Display(Name = "Sell")]
        sell
    }
}
