using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MockDataGenerator.Interfaces;

namespace MockDataGenerator.SpecialObjects.Rules
{
    public class TupleRule : TypeRule
    {
        public List<IDataRule> Types { set; get; }
    }
}
