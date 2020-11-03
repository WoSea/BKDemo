using CQRS.ResponseModels.QueryResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.RequestModels.QueryRequestModels
{
    public class GetOrderByIdRequestModel:IRequest<GetOrderByIdResponseModel>
    {
        public Guid OrderId { get; set; }
    }
}
