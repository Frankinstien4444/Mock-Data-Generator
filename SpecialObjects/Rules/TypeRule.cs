using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MockDataGenerator.SpecialObjects.Rules
{
    [Serializable]
    public class TypeRule : BaseRule
    {
        [DataMember]
        public String Assembly { set; get; }

        [DataMember]
        public String AssemblyPath { set; get; }
    }
}
