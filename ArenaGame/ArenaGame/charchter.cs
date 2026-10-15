using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class charachter
    {
        private string _name;
        private int _health;
        public string Name {  get { return _name; }  set { _name = value; } }
        public int Health { get { return _health; } set { if (value < 0) { _health = 0; } else if (value > 100) { _health = 100; } } }
        private static int _count;
        public static int Count { get { return _count; } }

        public charachter(string name)
        {
            Name = name;
            Health = 100;
            _count++;
        }
        public bool IsAlive()
        {
            if(_health > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetDescripiton()
        {
            return $"Name: {Name} ({Health})";
        }

    }
}
