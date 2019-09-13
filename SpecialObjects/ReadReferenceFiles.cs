using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildObjects.MapObjects;
using UniversalDataBase.Utilities;

namespace MockDataGenerator.SpecialObjects
{
    public static class ReadReferenceFiles
    {
        public static ReferenceData ReadFile(string fileName)
        {
            ReferenceData result = null;
            FileSerializations.FileDeserialization(fileName, ref result);
            return result;
        }

        public static ViableMapAndData LoadMap(string fileName)
        {
            ViableMapAndData loadedMap = null;
            FileSerializations.FileDeserialization(fileName, ref loadedMap);
            return loadedMap;
        }
    }
}
