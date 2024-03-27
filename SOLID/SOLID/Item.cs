﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Item : IActionOfItem
    {
        private string _name;
        public int Hitpoints { get; set; }

        public int Weight { get; set; }

        public int Healpoints { get; set; }

        public int Damagepoints { get; set; }

        public Item(string _name)
        {
            _name = "Karl";
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
