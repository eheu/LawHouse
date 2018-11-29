using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class Role : Entity
    {
        public Role()
        {
        }

        public Role(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
