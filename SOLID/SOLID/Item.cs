using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Item : IActionOfItem
    {
        private string _name;
        public int Hitpoints { get; }

        public int Weight { get; }

        public int Healpoints { get; }

        public int Damagepoints { get; }

        public Item(string _name)
        {
            _name = "Karl";
        }

        public string Name => _name;
    }
}
