﻿using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relation Property
        public virtual List<Product> Products { get; set; }
    }
}
