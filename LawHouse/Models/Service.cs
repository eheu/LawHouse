using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class Service : Entity
    {
        public Service()
        {
        }

        public Service(string name, double price, bool isHourly)
        {
            Name = name;
            Price = price;
            IsHourly = isHourly;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsHourly { get; set; }
    }
}
