using CQRS.Interfaces.ICommandHandlers;
using CQRS.RequestModels.CommandRequestModels;
using CQRS.ResponseModels.CommandResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Handlers.CommandHandlers
{
    public class MakeOrderCommandHandler:IMakeOrderCommandHandler
    {
        public MakeOrderResponseModel MakeOrder(MakeOrderRequestModel requestModel)
        {
            var result = new MakeOrderResponseModel
            {
                IsSuccess =true,
                OrderId = new Guid(g:"3131212")
            };
            return result;
        }
    }
}
