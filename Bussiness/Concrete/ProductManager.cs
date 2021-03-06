﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal )
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları
            return _productDal.GetAll();
        }
    }
}
