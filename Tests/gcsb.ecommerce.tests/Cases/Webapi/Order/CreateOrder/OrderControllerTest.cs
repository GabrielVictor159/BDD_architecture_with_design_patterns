using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using gcsb.ecommerce.application.Interfaces.Services;
using gcsb.ecommerce.webapi.UseCases;
using gcsb.ecommerce.webapi.UseCases.Order.CreateOrder;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Xunit.Frameworks.Autofac;

namespace gcsb.ecommerce.tests.Cases.Webapi.Order.CreateOrder
{
    [UseAutofacTestFramework]
    public class OrderControllerTest
    {
        private readonly OrderController createOrderController;
        private readonly INotificationService notificationService;
        public OrderControllerTest(
            OrderController createOrderController,
            INotificationService notificationService)
        {
            this.createOrderController = createOrderController;
            this.notificationService = notificationService;            
        }
        [Fact]
        public async Task ShouldExecuteCreateWithSucess()
        {
            var result = await createOrderController.CreateOrder(new webapi.UseCases.Order.CreateOrder.CreateOrderRequest(){OrderDate =DateTime.Today, TotalOrder = 1000});
            notificationService.HasNotifications.Should().BeFalse();
        }
        [Fact]
        public async Task ShouldExecuteCreateWithFailed()
        {
            var result = await createOrderController.CreateOrder(new webapi.UseCases.Order.CreateOrder.CreateOrderRequest(){OrderDate =DateTime.Today.AddDays(2), TotalOrder = 0});
            notificationService.HasNotifications.Should().BeTrue();
        }
    }
}