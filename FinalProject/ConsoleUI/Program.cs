﻿using Business;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program       
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());




            foreach (var product in productManager.GetByUnitPrice(100,101))
            {
                Console.WriteLine(product.ProductName);
            }





        }
    }
}
