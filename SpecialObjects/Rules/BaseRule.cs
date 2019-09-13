using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MockDataGenerator.Enums;
using MockDataGenerator.Interfaces;

namespace MockDataGenerator.SpecialObjects
{
    [Serializable]
    public abstract class BaseRule : IDataRule
    {
        [DataMember]
        public String Description { set; get; }
        [DataMember]
        public FieldTypes RuleType { set; get; }
        [DataMember]
        public bool IsRandom { set; get; }
        [DataMember]
        public String FieldName { set; get; }
        [DataMember]
        public String FieldDataType { set; get; }
        [DataMember]
        public bool ConvertToString { set; get; }
        [DataMember]
        public Guid RuleId { set; get; }
        [DataMember]
        public int MaxRecords { set; get; }

        public BaseRule()
        {
            RuleId = Guid.NewGuid();           
        }

        public virtual BaseRule Clone()
        {
            return (BaseRule)this.MemberwiseClone();
        }
    }
}
