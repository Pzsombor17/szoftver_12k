using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diakszallo
{
    public class Guest
    {
        private string _name {  get; set; }
        private int _age { get; set; }
        private bool _isStudent { get; set; }
        public string Name { get { return _name; }set { _name = value; } }
        public int Age { get { return _age; }set { if (age = value; } }
        public bool IsStudent { get { return _isStudent; }set { _isStudent = value; } }

        private static int _count { get; set; }
        public static int Count { get { return _count++; } }

        public Guest(string Name,int Age,bool IsStudent)
        {
            _name = Name;
            _age = Age;
            _isStudent = IsStudent;

        }
    }
}
