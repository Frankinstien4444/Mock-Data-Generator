using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MockDataGenerator.Interfaces;
using MockDataGenerator.SpecialObjects.Rules;

namespace MockDataGenerator.SpecialObjects
{
    public class TRule : TypeRule
    {
        public dynamic Types { set; get; }
    }
}
