using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class mage :charachter
    {
        private int _mana;
        public int Mana { get { return _mana; } set { if (value < 0) { _mana = 0; } else { _mana = value; } } }

        public mage(string name,int mana) : base(name)
        {
            Mana = mana;
        }
        public override string GetDescripiton()
        {
            return base.GetDescripiton() + "- Mana: "+Mana;
        }
        public override int AttackPower()
        {
            if(Mana >= 10)
            {
                Mana  -= 10;
                return 25;
            }
            return base.AttackPower();
        }
    }
}
