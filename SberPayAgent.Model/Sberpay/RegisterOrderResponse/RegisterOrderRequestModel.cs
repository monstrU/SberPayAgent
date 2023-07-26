

namespace SberPayAgent.Model.Sberpay.RegisterOrderResponse
{
    public class RegisterOrderRequestModel  
    {
        public string UserName { get; set; }
        public string  Password{ get; set; }
        public int  Amount{ get; set; }
        public string  Currency{ get; set; }
        public string  OrderNumber{ get; set; }
        public string  ReturnUrl{ get; set; }
        public string  FailUrl{ get; set; }
        public string  Description{ get; set; }
        public string OrderId { get; set; }
    }
}
