﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Core.Entities;

namespace Shopping.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
