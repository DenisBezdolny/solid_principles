using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator__Open_Closed_Principle_
{
    abstract class Goods
    {
        public Goods(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public abstract double Cost();

    }
}
