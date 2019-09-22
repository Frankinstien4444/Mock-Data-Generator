using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildObjects.Enums;
using BuildObjects.MapObjects;
using MockDataGenerator.SpecialObjects;

namespace MockDataGenerator.Utility
{
    public static class OutputTemplate
    {
        public static List<String> CreateTemplateNoParams(ViableMapAndData data)
        {
            List<String> results = new List<string>();
            foreach (DataStore aStore in data.StoredData)
            {
                results.AddRange(CreateTemplateNoParams(aStore.ActualData, data.TheMap, aStore.DataStoreName, String.Empty));
            }

            return results;
        }

        public static List<String> CreateTemplateParams(ViableMapAndData data)
        {
            List<String> results = new List<string>();
            foreach (DataStore aStore in data.StoredData)
            {
                results.AddRange(CreateTemplateParams(aStore.ActualData, data.TheMap, aStore.DataStoreName, String.Empty));
            }

            return results;
        }

        public static List<String> CreateTemplateNoParams(DataTable dg, MapedObject map, String storeName, String customName)
        {
            List<String> result = new List<string>();
            if (String.IsNullOrEmpty(customName))
                customName = String.Format("_{0}", NameSpaceManager.RemoveNameSpace(map.ClassName).ToLower());
            string createObject = String.Format("{0} {1} = new {0}();", NameSpaceManager.RemoveNameSpace(map.ClassName), customName);
            string afterObjects = String.Format("{1} = new {0}();", NameSpaceManager.RemoveNameSpace(map.ClassName), customName);
            string insert = InputBox.frmInput.InputBox("Adding a Object to a Collection? Enter code:", null, customName, false);
            result.Add(createObject);
            int count = -1;
            foreach (DataRow aRow in dg.Rows)
            {
                count++;
                
                if (count > 0)
                {
                    if (!String.IsNullOrEmpty(insert))
                        result.Add(insert);
                    result.Add(" ");                   
                    result.Add("//NewObject");
                    result.Add(afterObjects);
                }
                DataMapType storeType = DataMapType.None;
                if (Enum.TryParse<DataMapType>(storeName, out storeType))
                {
                    switch (storeType)
                    {
                        case DataMapType.FieldColumnMap:
                            BuildFieldTemplate(customName, aRow, map.FieldMaps, result);
                            break;
                        case DataMapType.PropertyColumnMap:
                            BuildPropertyTemplate(customName, aRow, map.PropMaps, result);
                            break;                            
                    }
                }
            }
            if (!String.IsNullOrEmpty(insert))
                result.Add(insert);
            return result;
        }

        private static void BuildPropertyTemplate(string customName, DataRow aRow, List<PropertyColumnMap> propertyMaps, List<String> result)
        {
            foreach (ColumnMap aMap in propertyMaps)
            {
                result.Add(BuildNoParamTemplate.BuildTemplate(customName, aRow, aMap));
            }
        }

        private static void BuildFieldTemplate(string customName, DataRow aRow, List<FieldColumnMap> fieldMaps, List<String> result)
        {
            foreach (ColumnMap aMap in fieldMaps)
            {
                result.Add(BuildNoParamTemplate.BuildTemplate(customName, aRow, aMap));
            }
        }

        private static void BuildParamTemplate(MethodParameterMap aMap, DataRow aRow, List<String> results, string customName, string className, bool declareClass = false)
        {
            string period = ".";
            string aSpace = " ";
            if (!declareClass)
                aSpace = String.Empty;

            StringBuilder result = new StringBuilder();
            int count = 0;
                string method = "{0}{1}{2}{3}{4}({5});";
                foreach (ParameterColumnMap cMap in aMap.ColumnParameterMaps)
                {
                    result.Append(BuildParameterTemplate.BuildTemplate(aRow, cMap));                    
                }
                string parameters = result.ToString();
                int indx = parameters.LastIndexOf(",");
                parameters = parameters.Remove(indx);
            if (aMap.MethodName == ".ctor")
            {
                string preFix = String.Empty;
                if (declareClass)
                    preFix = className;
                results.Add(string.Format(method, preFix, aSpace, customName, " = new ", className, parameters));
                count++;
            }
            else
            {
                results.Add(string.Format(method, customName, period, aMap.MethodName, "", "", parameters));
            }
            
        }

        public static List<String> CreateTemplateParams(DataTable dg, MapedObject map, String storeName, String customName)
        {
            List<String> results = new List<string>();
            if (String.IsNullOrEmpty(customName))
                customName = String.Format("_{0}", NameSpaceManager.RemoveNameSpace(map.ClassName).ToLower());
            
            string insert = InputBox.frmInput.InputBox("Adding a Object to a Collection? Enter code:", null, customName, false);
            var aMap = map.MethodParameters.Where(x => x.MethodName == storeName).FirstOrDefault();
            int count = -1;
            bool delcareClass = true;
            foreach (DataRow aRow in dg.Rows)
            {
                count++;

                if (count > 0)
                {
                    if (!String.IsNullOrEmpty(insert))
                        results.Add(insert);
                    results.Add(" ");
                    results.Add("//NewObject");
                    delcareClass = false;
                }
               
                BuildParamTemplate(aMap, aRow, results, customName, map.ClassName, delcareClass);      
                     
            }
            if (!String.IsNullOrEmpty(insert))
                results.Add(insert);
            return results;
        }

    }
}
