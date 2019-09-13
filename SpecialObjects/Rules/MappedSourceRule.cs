using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using BuildObjects.MapObjects;

namespace MockDataGenerator.SpecialObjects.Rules
{
    [Serializable]
    public class MappedSourceRule : BaseRule
    {
        [DataMember]
        public ViableMapAndData MappedSource { set; get; }
    }
}
