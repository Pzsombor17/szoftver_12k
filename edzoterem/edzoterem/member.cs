using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace edzoterem
{
    public class Member
    {
        private string _name { get; set ;  }
        private int _age { get; set; }
        private bool _isStudent { get; set; }
        private int _visits { get; set; }
        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public bool IsStudent { get { return _isStudent; } set { _isStudent = value; } }
        public int Visits { get { return _visits; } set { _visits = value; } }

        public Member(string Name, int Age, bool IsStudent)
        {
            _name = Name;
            _age = Age;
            _isStudent = IsStudent;
            _visits = 0;
        }
        public void CheckIn()
        {
            Visits++;
        }
        public string Describe()
        {
            string student = string.Empty;
            if (IsStudent)
            {
                student = "diák";
            }
            else
            {
                student = "normál";
            }
            return $"{Name} ({Age} éves, {student}) - {Visits} látogatás";
        }
    }
}
