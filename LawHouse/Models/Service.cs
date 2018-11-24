using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    class Service : Entity
    {
        public Service()
        {
        }

        public Service(string name, decimal price, bool isHourly)
        {
            Name = name;
            Price = price;
            IsHourly = isHourly;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public Boolean IsHourly { get; set; }
    }
}
