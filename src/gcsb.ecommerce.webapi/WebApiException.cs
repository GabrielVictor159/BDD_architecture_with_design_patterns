using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gcsb.ecommerce.webapi
{
    public class WebApiException: Exception
    {
        public WebApiException(string businessMessage)
             : base(businessMessage)
        {
        }
        
    }
}