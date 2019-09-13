using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MockDataGenerator.Enums;

namespace MockDataGenerator.SpecialObjects.Rules
{
    public class DataSourceRule : BaseRule
    {
        [DataMember]
        public DataResources TypeofInternalSource { set; get; }        

        [DataMember]
        public ListCtrlType ListControlType { set; get; }
    }
}
