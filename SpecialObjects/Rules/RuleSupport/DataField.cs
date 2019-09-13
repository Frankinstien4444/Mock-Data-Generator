using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MockDataGenerator.SpecialObjects.Rules.RuleSupport
{
    [Serializable]
    public class DataField
    {
        /// <summary>
        /// represents the data source column or treenode
        /// </summary>
        [DataMember]
        public String ColumnName { set; get; }
        /// <summary>
        /// represents a field, parameter or property of an object
        /// </summary>
        [DataMember]
        public String FieldName { set; get; }

        public DataField()
        {

        }

        public DataField(string column)
        {
            ColumnName = column;
        }
    }
}
