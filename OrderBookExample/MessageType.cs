using System.ComponentModel.DataAnnotations;

namespace OrderBookExample
{
    public enum MessageType
    {
        [Display(Name = "Add")]
        a,
        [Display(Name = "Cancel")]
        c
    }
}
