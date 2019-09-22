using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using BuildObjects.Enums;
using BuildObjects.MapObjects;
using MockDataGenerator.Interfaces;

namespace MockDataGenerator.SpecialObjects
{
    [Serializable]
    public class ReferenceData
    {
        [DataMember]
        public List<BaseStore> StoreReferences { set; get; }        
        [DataMember]
        public String RefreshFile { set; get; }

        public ReferenceData()
        {
            StoreReferences = new List<BaseStore>();
        }
    }

    [Serializable]
    public class SQLStore : BaseStore
    {
        [DataMember]
        public String SQL { set; get; }        
    }

    public class RuleStore : BaseStore
    {
        [DataMember]
        public List<IDataRule> Rules { set; get; }
    }

    [Serializable]
    public abstract class BaseStore
    {
        [DataMember]
        public Guid MapID { private set; get; }
        [DataMember]
        public String DataStoreName { set; get; }
        [DataMember]
        public DataMapType MapType { set; get; }

        [DataMember]
        public int ParamterCount { set; get; }

        public BaseStore()
        {
            MapID = Guid.NewGuid();
        }
    }
}
