using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IActionOfItem
    {
        int Hitpoints { get; }
        int Weight { get; }
        int Healpoints { get; }
        int Damagepoints { get; }
        int GetDamage(int damagepoints);
        int GetHeal(int healpoints);



    }
}
