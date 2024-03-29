﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Entities.Concrete;

namespace Shopping.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart,int productId);
        List<CartLine> List(Cart cart);
    }

    
}
