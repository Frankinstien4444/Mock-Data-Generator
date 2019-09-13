using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MockDataGenerator.Enums;
using MockDataGenerator.Interfaces;

namespace MockDataGenerator.SpecialObjects
{
    public class CommonCtrlProperies
    {
        public IDataRule Result { set; get; }
        public FieldTypes GeneralType { set; get; }
        public bool Random { set; get; }
        public String Description { set; get; }
        public String FieldDisplay { set; get; }
        public String TypeDisplay { set; get; }

        public CommonCtrlProperies()
        {
            GeneralType = FieldTypes.None;
            Random = false;
        }

    }
}
