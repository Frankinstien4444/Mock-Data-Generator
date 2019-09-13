using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MockDataGenerator.Enums;

namespace MockDataGenerator.SpecialObjects
{
    [Serializable]
    public class NumberRule : BaseRule
    {
        [DataMember]
        public Double Start { set; get; }
        [DataMember]
        public Double End { set; get; }
        [DataMember]
        public Double Increment { set; get; }             
        
    }
}
