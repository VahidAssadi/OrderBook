using System.ComponentModel.DataAnnotations;

namespace OrderBookExample
{
    public enum OrderType
    {
        [Display(Name = "Buy")]
        b,
        [Display(Name = "Sell")]
        s
    }
}
