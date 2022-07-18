using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IProductService
    {
        List<Product> GetAll();//Bütün datayı getirir
        List<Product> GetAllByCategoryId(int id);//Category datasını verilen category Idsine göre getirir   
        List<Product> GetByUnitPrice(decimal min, decimal max);//Belirtilen fiyat aralığındaki verileri getirir.
     }
}
