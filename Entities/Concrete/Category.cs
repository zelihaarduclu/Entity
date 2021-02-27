using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public int CatogoryId { get; set; }
        public string CatogoryName { get; set; }
    }
}
