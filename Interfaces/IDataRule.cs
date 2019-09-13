using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MockDataGenerator.Enums;

namespace MockDataGenerator.Interfaces
{
    
    public interface IDataRule
    {
        [DataMember]
        String Description { set; get; }
        [DataMember]
        FieldTypes RuleType { set; get; }
        [DataMember]
        bool IsRandom { set; get; }
        [DataMember]
        String FieldName { set; get; }
        [DataMember]
        String FieldDataType { set; get; }
        [DataMember]
        bool ConvertToString { set; get; }
        [DataMember]
        Guid RuleId { set; get; }
    }
}
