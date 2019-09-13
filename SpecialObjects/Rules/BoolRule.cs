using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MockDataGenerator.SpecialObjects
{
    [Serializable]
    public class BoolRule : BaseRule
    {
        [DataMember]
        public bool AlwaysTrue { set; get; }

        [DataMember]
        public bool AlwaysFalse { set; get; }
    }
}
