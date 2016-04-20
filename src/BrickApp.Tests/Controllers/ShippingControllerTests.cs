using Microsoft.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using BrickApp.Controllers;
using BrickApp.Models.BrickStore;
using Xunit;

namespace BrickApp.Tests.Controllers
{
    public class ShippingControllerTests
    {
        [Fact]
        public void GetPendingOrders()
        {
            var builder = new DbContextOptionsBuilder<BrickStoreContext>();
            builder.UseInMemoryDatabase();
            var options = builder.Options;

            using (var context = new BrickStoreContext(options))
            {
                var orders = new List<Order>
                {
                    new Order { State = OrderState.CheckingOut, ShippingDetails = new OrderShippingDetails() },
                    new Order { State = OrderState.Placed, ShippingDetails = new OrderShippingDetails() },
                    new Order { State = OrderState.Filling, ShippingDetails = new OrderShippingDetails() },
                    new Order { State = OrderState.ReadyToShip, ShippingDetails = new OrderShippingDetails() },
                    new Order { State = OrderState.Shipped, ShippingDetails = new OrderShippingDetails() },
                    new Order { State = OrderState.Delivered, ShippingDetails = new OrderShippingDetails() },
                    new Order { State = OrderState.Cancelled, ShippingDetails = new OrderShippingDetails() },
                };

                context.AddRange(orders);
                context.AddRange(orders.Select(o => o.ShippingDetails));
                context.SaveChanges();
            }

            using (var context = new BrickStoreContext(options))
            {
                var controller = new ShippingController(context);
                var orders = controller.PendingOrders();
                Assert.Equal(1, orders.Count());
            }
        }
    }
}
