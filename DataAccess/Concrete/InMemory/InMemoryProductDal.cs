using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {

            _products = new List<Product> { 
                    new Product{ProductId=1, ProductName="bardak",CatogoryId=1,UnitPrice=15,UnitsInStock=15}
            
            };
        }

        public int ProductId { get; private set; }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete=null;

            
            productToDelete = _products.SingleOrDefault(p=>product.ProductId==ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId) => _products.Where(p => p.CatogoryId == categoryId).ToList();

        public void Update(Product product)
        {
           Product productToUpdate = _products.SingleOrDefault(p => product.ProductId == ProductId);
            productToUpdate.ProductName = product.ProductName;
        }
    }
}
