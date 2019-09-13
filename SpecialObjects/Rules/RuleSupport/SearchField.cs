using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MockDataGenerator.Enums;

namespace MockDataGenerator.SpecialObjects.Rules.RuleSupport
{
    [Serializable]
    public class SearchField
    {
        /// <summary>
        /// represents the data source column or treenode
        /// </summary>
        [DataMember]
        public string ColumnName { set; get; }
        [DataMember]
        public LogicTypes Logic { set; get; }
        [DataMember]        
        public String RangeStart { set; get; }
        [DataMember]
        public String RangeEnd { set; get; }
        [DataMember]
        public String RegularExpression { set; get; }
        [DataMember]
        public Boolean IsRandom { set; get; }

        public SearchField()
        {

        }

        public SearchField(string column)
        {
            ColumnName = column;
        }

        public SearchField(string column, LogicTypes logic)
        {
            ColumnName = column;
            Logic = logic;
        }
    }
}
