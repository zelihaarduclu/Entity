using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
