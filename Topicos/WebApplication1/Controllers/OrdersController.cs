using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrdersController
    {
        [HttpGet]
        public JsonResult GetOrders()
        {
            JsonResult elResultado = new JsonResult(new List<Object>() {
                 new {id = 5, orderDate=DateTime. Now},
                 new {id = 25, orderDate=DateTime. Now. AddMinutes(-200)}
            });
            return elResultado;
        }
    }
}
