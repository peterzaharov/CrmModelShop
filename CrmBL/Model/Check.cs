﻿using System;
using System.Collections.Generic;

namespace CrmBL.Model
{
    public class Check
    {
        public int CheckId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }
        public DateTime DateOfCreation{ get; set; }
        public virtual ICollection<Sell> Sells { get; set; }
        public override string ToString()
        {
            return $"№{CheckId} от {DateOfCreation.ToString("dd.MM.yy HH:mm:ss")}";
        }
    }
}
