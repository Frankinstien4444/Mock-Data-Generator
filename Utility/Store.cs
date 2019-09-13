using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildObjects.MapObjects;
using MockDataGenerator.SpecialObjects;
using UniversalDataBase.Utilities;

namespace MockDataGenerator.Utility
{
    public static class Store
    {
        public static void StoreMap(MapedObject aMap, String fileName)
        {
            FileSerializations.FileSerialization(fileName, aMap);
        }

        public static void StoreData(DataTable data, String fileName)
        {
            FileSerializations.FileSerialization(fileName, data);
        }

        public static void StoreMapAndData(ReferenceData refInfo, String fileName)
        {
            FileSerializations.FileSerialization(fileName, refInfo);
        }
        public static void StoreMapAndData(ViableMapAndData all, String fileName)
        {
            FileSerializations.FileSerialization(fileName, all);
        } 
        
        public static void SaveTextOutput(List<String> data, string fileName)
        {
            using (System.IO.StreamWriter output = new System.IO.StreamWriter(fileName))
            {
                foreach(String aLine in data)
                    output.WriteLine(aLine);
            }
        }
    }   
}
