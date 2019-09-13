using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MockDataGenerator.SpecialObjects
{
    [Serializable]
    public class StringRule : BaseRule
    {
        [DataMember]
        public int StringLength { set; get; }
        [DataMember]        
        public bool RandomPosition { set; get; }

        [DataMember]
        public List<String> Entries { set; get; }
    }
}
