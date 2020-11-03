using CQRS.ResponseModels.CommandResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.RequestModels.CommandRequestModels
{
    public class MakeOrderRequestModel 
    {       
        //using prop + Tab in Visual Studio
        public Guid OrderId { get; set; }
        public string OrderName { get; set; }
        public DateTime DateOrder { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public Guid OrderPeronId { get;  set; }
    }
}
