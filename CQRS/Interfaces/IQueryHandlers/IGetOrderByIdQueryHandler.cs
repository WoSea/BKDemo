
using CQRS.RequestModels.QueryRequestModels;
using CQRS.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Interfaces.IQueryHandlers
{
    public interface IGetOrderByIdQueryHandler
    {
        GetOrderByIdResponseModel GetOrderById(GetOrderByIdRequestModel requestModel);
    }
}
