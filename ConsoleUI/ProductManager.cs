using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class ProductManager
    {
        private InMemoryProductDal ınMemoryProductDal;

        public ProductManager(InMemoryProductDal ınMemoryProductDal)
        {
            this.ınMemoryProductDal = ınMemoryProductDal;
        }

        internal IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}