using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr6_part2
{
    class ForResearch : IComparable
    {
        public ForResearch() { }
        public ForResearch(int i) { }
        public ForResearch(string str) { }
        public int Multiply(int x, int y) { return x * y; }
        public int Devide(int x, int y) 
        {
            if (y != 0) return x / y;
            else return 0;
        }
        [UserAttribute("Описание для property1")]
        public string first_proper
        {
            get { return _first_proper; }
            set { _first_proper = value; }
        }
        private string _first_proper;

        public int second_proper { get; set; }

        [UserAttribute(Description = "Описание для property3")]
        public double third_proper { get; private set; }

        public int field1;
        public float field2;
        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}
