﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreCoreApplication.ViewModels;

namespace WebStoreCoreApplication.Controllers.Infrastructure.Interfaces
{
    public interface ICartService
    {
        void DecrementFromCart(int id);
        void RemoveFromCart(int id);
        void RemoveAll();
        void AddToCart(int id);

        CartViewModel TransformCart();
    }
}
