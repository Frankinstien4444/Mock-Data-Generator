using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildObjects.Enums;
using BuildObjects.MapObjects;

namespace MockDataGenerator.SpecialObjects
{
    public class MapReferences
    {
        public ViableMapAndData ViableInfo { set; get; }
        public ReferenceData ReferenceInfo { set; get; }
        public DataMapType LastMap { set; get; }  
        public MethodParameterMap LastMethodMap { set; get; }
        public MapReferences()
        {
            ReferenceInfo = new ReferenceData();
        }
    }
}
