using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MockDataGenerator.SpecialObjects.Rules
{
    [Serializable]
    public class SingleFieldDataSourceRule : DataSourceRule
    {
        [DataMember]
        public String RangeStart { set; get; }
        [DataMember]
        public String RangeEnd { set; get; }
        [DataMember]
        public String RegularExpression { set; get; }
    }
}
