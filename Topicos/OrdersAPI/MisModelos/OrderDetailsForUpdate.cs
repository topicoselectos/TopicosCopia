﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersAPI.MisModelos
{
    public class OrderDetailsForUpdate
    {
        public int IdArticulo { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
    }
}