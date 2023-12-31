﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager _productManager = new ProductManager(new InMemoryProductDal());

            foreach (var product in _productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
