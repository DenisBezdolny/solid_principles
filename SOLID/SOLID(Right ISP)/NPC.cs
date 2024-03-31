using SOLID_Right_ISP_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class NPC : IActionOfItem,IDamaging, IHealing, IItemsForDamage
    {
        private string _name;
        public int Hitpoints {  get; set; }

        public int Weight { get; set; }

        public int Damagepoints { get; set; }

        public NPC (string name)
        {
            _name = name;
        }

        public string Name => _name;

        public int GetDamage(int damagepoints)
        {
            Hitpoints = Hitpoints - damagepoints;

            if (Hitpoints > 0) { return Hitpoints; }
            else { return Hitpoints = 0; }
        }
        public int GetHeal(int healpoints)
        {
            return Hitpoints = Hitpoints + healpoints;
        }
    }
}
