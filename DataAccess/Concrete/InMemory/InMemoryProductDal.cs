using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
               new Product()
               {
                   ProductId=1,CategoryId=2,ProductName="elma",UnitPrice=5,UnitsInStock=2
               },
               new Product()
               {
                   ProductId=2,CategoryId=12,ProductName="tatlı",UnitPrice=4,UnitsInStock=44
               },
               new Product()
               {
                   ProductId=3,CategoryId=21,ProductName="sirke",UnitPrice=5,UnitsInStock = 2
               },
                new Product()
               {
                   ProductId=4,CategoryId=222,ProductName="üzüm",UnitPrice = 15, UnitsInStock = 21
               },
                new Product()
               {
                   ProductId=4,CategoryId=222,ProductName="üzüm",UnitPrice = 25, UnitsInStock = 21
               }


            };
        }

        public void Add(Product product)
        {
           _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Product productToDelete=null;

            //foreach (var p in _products)
            //{
            //    if (product.ProductId==p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}

            Product productToDelete;

            productToDelete =_products.SingleOrDefault(p=>p.ProductId==product.ProductId);

            _products.Remove(productToDelete);

        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.CategoryId=product.CategoryId;
            productToUpdate.ProductName=product.ProductName;
            productToUpdate.UnitPrice=product.UnitPrice;
            productToUpdate.UnitsInStock=product.UnitsInStock;




        }
    }
}
