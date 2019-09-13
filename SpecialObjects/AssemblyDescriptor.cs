using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MockDataGenerator.SpecialObjects
{
    public class AssemblyDescriptor
    {
        public Assembly Assembly { set; get; }
        public IEnumerable<Type> Enums { set; get; }
        public IEnumerable<Type> AbstractClasses { set; get; }
        public IEnumerable<Type> Interfaces { set; get; }
    }
}
