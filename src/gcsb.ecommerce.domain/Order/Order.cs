using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gcsb.ecommerce.domain.Validator.Order;

namespace gcsb.ecommerce.domain.Order
{
    public class Order : Entity
    {
        public DateTime OrderDate { get; private set; }
        public decimal TotalOrder { get; private set; }

        public Order(Guid id,DateTime orderDate, decimal totalOrder)
        {
            Id = id;
            OrderDate = orderDate;
            TotalOrder = totalOrder;
            Validate(this, new OrderValidator());
        }
        public static Order New(Guid id, DateTime orderDate, decimal totalOrder)
            => new(id, orderDate, totalOrder);
    }
}