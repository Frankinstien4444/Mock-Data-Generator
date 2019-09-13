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
    public class TimeRule : BaseRule
    {
        [DataMember]
        public DateTime Start { set; get; }
        [DataMember]
        public DateTime End { set; get; }
        [DataMember]
        public Double Increment { set; get; }
        [DataMember]
        public DateTimeRateTypes RateType { set; get; }
    }
}
