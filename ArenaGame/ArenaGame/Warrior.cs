using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Warrior : charachter
    {
        private int _armor;
        public int Armor { get { return _armor; } set { if (value < 0) { _armor = 0; } else { _armor = value; } } }

        public Warrior(string name,int armor) : base(name)
        {
            Armor = armor;
        }

    }
}
