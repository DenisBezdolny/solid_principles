using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Weapon : IActionOfItem
    {
        private string _name;
        public int Hitpoints {  get; }

        public int Weight { get; }

        public int Healpoints { get; }

        public int Damagepoints { get; }

        public Weapon (string _name)
        {
            _name = "Karl";
        }

        public string Name => _name;
    }
}
