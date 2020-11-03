using CQRS.Interfaces.IQueryHandlers;
using CQRS.RequestModels.QueryRequestModels;
using CQRS.ResponseModels.QueryResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Handlers.QueryHandlers
{
    /*
       public class GetOrderByIdQueryHandler:IGetOrderByIdQueryHandler
    {
        public GetOrderByIdResponseModel GetOrderById(GetOrderByIdRequestModel requestModel)
        {
            var orderDetails = new GetOrderByIdResponseModel();
            return orderDetails;
        }
    }
     */
    public class GetOrderByIdQueryHandler:IRequestHandler<GetOrderByIdRequestModel,GetOrderByIdResponseModel>
    {
        public async Task<GetOrderByIdResponseModel> Handle(GetOrderByIdRequestModel request,CancellationToken cancellationToken)
        {
            var orderDetails = new GetOrderByIdResponseModel();
            return orderDetails;
        }
    }
}
