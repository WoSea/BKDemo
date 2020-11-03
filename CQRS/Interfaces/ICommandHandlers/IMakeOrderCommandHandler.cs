using CQRS.RequestModels.CommandRequestModels;
using CQRS.ResponseModels.CommandResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Interfaces.ICommandHandlers
{
    public interface IMakeOrderCommandHandler
    {
        MakeOrderResponseModel MakeOrder(MakeOrderRequestModel requestModel);
    }
}
