using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MockDataGenerator.Enums;
using MockDataGenerator.SpecialObjects.Rules;
using MockDataGenerator.SpecialObjects.Rules.RuleSupport;

namespace MockDataGenerator.SpecialObjects
{
    [Serializable]
    public class MultiFieldDataSourceRule : DataSourceRule
    {
       [DataMember]
        public List<SearchField> SearchFields { set; get; }
        [DataMember]
        public List<DataField> FieldColumnMap { set; get; }           
    }
}
