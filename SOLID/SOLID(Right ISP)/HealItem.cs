using SOLID_Right_ISP_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class HealItem : IActionOfItem,IItemsForHealing
    {
        private string _name;
        public int Hitpoints {  get; set; }

        public int Weight { get; set; }

        public int Healpoints { get; set; }

        public HealItem (string _name)
        {
            _name = "Bandage";
        }

        public string Name => _name;

    }
}
