using CQRS.Interfaces.IQueryHandlers;
using CQRS.RequestModels.QueryRequestModels;
using CQRS.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Handlers.QueryHandlers
{
    public class GetOrderByIdQueryHandler:IGetOrderByIdQueryHandler
    {
        public GetOrderByIdResponseModel GetOrderById(GetOrderByIdRequestModel requestModel)
        {
            var orderDetails = new GetOrderByIdResponseModel();
            return orderDetails;
        }
    }
}
