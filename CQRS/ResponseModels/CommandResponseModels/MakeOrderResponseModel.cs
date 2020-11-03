using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.ResponseModels.CommandResponseModels
{
    public class MakeOrderResponseModel
    {
        public bool IsSuccess { get; set; } 
        public Guid OrderId { get; set; }
    }
}
