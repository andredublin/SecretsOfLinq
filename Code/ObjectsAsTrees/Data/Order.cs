﻿using System.Collections.Generic;

namespace ObjectsAsTrees.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public IList<OrderItem> OrderItems { get; set; }
    }
}
