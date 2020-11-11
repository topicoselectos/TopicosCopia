using Microsoft.AspNetCore.Mvc;
using OrdersAPI;
using OrdersAPI.MisModelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOrders()
        {
            var elResultado = OrdersDataStore.Current.OrdersList;
            return Ok(elResultado);
        }

        private Orders BuscarOrden (int orderId)
        {
            var laOrden = OrdersDataStore.Current.OrdersList.FirstOrDefault(o => o.Id == orderId);
            return laOrden;
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            // Verificar si la orden existe
            var laOrden = BuscarOrden(id);
            if (laOrden == null)
                return NotFound();
            return Ok(laOrden);
        }
    }
}
