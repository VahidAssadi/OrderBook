using System.ComponentModel.DataAnnotations;

namespace OrderBookExample
{
    //public class Message
    //{
    //    public void Add(MessageType messageType, Order order)
    //    {

    //    }

    //    public void Cancel(MessageType messageType , int orderId) 
    //    { 
    //    }
    //}
    public enum MessageType
    {
        [Display(Name = "Add")]
        a,
        [Display(Name = "Cancel")]
        c
    }
}
