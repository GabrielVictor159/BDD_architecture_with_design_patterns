using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gcsb.ecommerce.application.Boundaries;
using Microsoft.AspNetCore.Mvc;

namespace gcsb.ecommerce.webapi.UseCases.Order.GetOrder
{
    public class GetOrderPresenter : Presenter<List<domain.Order.Order>,OrderResponse>
    {

    }
}
