using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace gcsb.ecommerce.webapi.UseCases.Order.RemoveOrder
{
    [DataContract(Name = "RemoveOrderRequest")]
    public class RemoveOrderRequest
    {
        public Guid id { get; set; }
    }
}