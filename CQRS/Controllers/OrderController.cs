using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.Interfaces.ICommandHandlers;
using CQRS.Interfaces.IQueryHandlers;
using CQRS.RequestModels.CommandRequestModels;
using CQRS.RequestModels.QueryRequestModels;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        /*   // Before implementing MediatR
        private readonly IGetOrderByIdQueryHandler _getOrderByIdQueryHandler;
        private readonly IMakeOrderCommandHandler _makeOrderCommandHandler;

        public OrderController(IGetOrderByIdQueryHandler getOrderByIdQueryHandler,
            IMakeOrderCommandHandler makeOrderCommandHandler)
        {
            _getOrderByIdQueryHandler = getOrderByIdQueryHandler;
            _makeOrderCommandHandler = makeOrderCommandHandler;
        }

        */
        private readonly IMediator _mediator;
        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost(template:"makeorder")]
        public IActionResult MakeOrder([FromBody] MakeOrderRequestModel requestModel)
        {
            //var response = _makeOrderCommandHandler.MakeOrder(requestModel);
            var response = _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet(template:"order")]
        public IActionResult OrderDetails([FromBody] GetOrderByIdRequestModel requestModel)
        {
            //var response = _getOrderByIdQueryHandler.GetOrderById(requestModel);
            var response = _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}
/*Postmam
 * POST: http://localhost:44398/api/order/makeorder
   {
    "orderId":"f0926a06-71b5-4007-661c-2225875db308";
    "orderName": "My VClient",
    "dateOrder": "2020-11-03T00:00:00",
    "productId": "f0926a06-71b5-4007-661c-2225875db999" ,
    "quantity": 10 ,
    "amount": 1000 ,
    "orderPersonId": "f0926a06-71b5-4007-661c-2225875db308" ,
  }
 */