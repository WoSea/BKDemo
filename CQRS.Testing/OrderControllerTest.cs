using CQRS.RequestModels.CommandRequestModels;
using MediatR;
using Moq;
using System;
using Xunit;
using CQRS;
using System.Threading;
using CQRS.ResponseModels.CommandResponseModels;
using CQRS.Controllers;
using Microsoft.AspNetCore.Mvc;
using CQRS.RequestModels.QueryRequestModels;
using CQRS.ResponseModels.QueryResponseModels;

namespace CQRS.Testing
{
    public class OrderControllerTest
    {
        private Mock<IMediator> Mediator;
        public OrderControllerTest()
        {
            Mediator = new Mock<IMediator>();
        } 
        [Fact]
        public void MakeOrder_Success_Result()
        {
            var makeOrderRequestModel = new MakeOrderRequestModel();
            Mediator.Setup(x => x.Send(It.IsAny<MakeOrderRequestModel>(), new CancellationToken())).
                ReturnsAsync(new MakeOrderResponseModel { IsSuccess=true,OrderId=Guid.NewGuid()});
            var orderController = new OrderController(Mediator.Object);
            //action
            var result = orderController.MakeOrder(makeOrderRequestModel);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetOrderById_Success_Result()
        {
            var getOrderByIdRequestModel = new GetOrderByIdRequestModel();
            Mediator.Setup(x => x.Send(It.IsAny<GetOrderByIdRequestModel>(), new CancellationToken())).
                ReturnsAsync(new GetOrderByIdResponseModel());
            var orderController = new OrderController(Mediator.Object);

            //Action
            var result = orderController.OrderDetails(getOrderByIdRequestModel);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
