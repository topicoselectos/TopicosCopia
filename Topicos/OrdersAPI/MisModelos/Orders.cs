﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersAPI.MisModelos
{
    public class Orders
    {

        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public ICollection<OrderDetail> LosDetalles { get; set; }
    }
}
