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

        public Service(string name, float price, bool isHourly, string description)
        {
            Name = name;
            Price = price;
            IsHourly = isHourly;
            Description = description;
        }

        public string Name { get; set; }
        public float Price { get; set; }
        public bool IsHourly { get; set; }
        public string Description { get; set; }
    }
}
