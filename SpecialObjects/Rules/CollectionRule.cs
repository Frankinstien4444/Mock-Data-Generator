using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using BuildObjects.MapObjects;
using MockDataGenerator.Enums;
using MockDataGenerator.Interfaces;
using MockDataGenerator.SpecialObjects.Rules;

namespace MockDataGenerator.SpecialObjects
{
    [Serializable]
    public class CollectionRule : TypeRule
    {
        [DataMember]
        public GenericCollections Generic { set; get; }

        [DataMember]
        public IDataRule ValueRule { set; get; }

        [DataMember]
        public IDataRule KeyRule { set; get; }        
    }
}
