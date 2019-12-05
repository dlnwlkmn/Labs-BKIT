using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr6_part2
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]

    class UserAttribute: Attribute
    {
        public UserAttribute() { }
        public UserAttribute(string DescriptionParam)
        {
            Description = DescriptionParam;
        }

        public string Description { get; set; }
    }
}
