using CQRS.Interfaces.ICommandHandlers;
using CQRS.RequestModels.CommandRequestModels;
using CQRS.ResponseModels.CommandResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Handlers.CommandHandlers
{
    /*
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
     */
    public class MakeOrderCommandHandler:IRequestHandler<MakeOrderRequestModel,MakeOrderResponseModel>
    {
        public async Task<MakeOrderResponseModel> Handle(MakeOrderRequestModel request,CancellationToken cancellationToken)
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
