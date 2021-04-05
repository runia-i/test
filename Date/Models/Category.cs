using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Date.Models
{
    public class Category
    {
        public int id { set; get; }

        public string nameCategory { set; get; }

        public string desk { set; get; }

        public List<Car> cars { set; get; }
    }
}
