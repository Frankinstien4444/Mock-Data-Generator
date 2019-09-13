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
                result.Add(BuildTemplate(customName, aRow, aMap));
            }
        }

        private static void BuildFieldTemplate(string customName, DataRow aRow, List<FieldColumnMap> fieldMaps, List<String> result)
        {
            foreach (ColumnMap aMap in fieldMaps)
            {
                result.Add(BuildTemplate(customName, aRow, aMap));
            }
        }
        private static String BuildTemplate(string customName, DataRow aRow, ColumnMap aMap)
        {
                string test = String.Empty;
                            
               if (aMap.IsNullable)
               {
                   if (aMap.DataType.Equals("System.DateTime?") || aMap.DataType.Equals("System.String?"))
                   {
                       test = string.Format(@"{0}.{1} = {2};", customName, NameSpaceManager.RemoveNameSpace(GetMapFieldPropName(aMap)), SetNullableDateValue(aRow, aMap));
                   }
                   else
                      test = string.Format("{0}.{1} = {2};", customName, NameSpaceManager.RemoveNameSpace(GetMapFieldPropName(aMap)), SetNullableValue(aRow, aMap));
               }
               else if (aMap.DataType.Equals("System.String"))
                    test = string.Format(@"{0}.{1} = ""{2}"";", customName, NameSpaceManager.RemoveNameSpace(GetMapFieldPropName(aMap)), aRow.Field<object>(aMap.ColumnName));
               else if (aMap.DataType.Equals("System.DateTime"))
                    test = string.Format(@"{0}.{1} = DateTime.Parse(""{2}"");", customName, NameSpaceManager.RemoveNameSpace(GetMapFieldPropName(aMap)), aRow.Field<object>(aMap.ColumnName));
               else if (aMap.DataType.Equals("System.Guid"))
               {
                    test = string.Format(@"{0}.{1} = Guid.ParseExact(""{2}"");", customName, NameSpaceManager.RemoveNameSpace(GetMapFieldPropName(aMap)), aRow.Field<object>(aMap.ColumnName));
               }
               else if (aMap.DataType.Equals("System.Boolean"))
               {
                   test = string.Format("{0}.{1} = {2};", customName, NameSpaceManager.RemoveNameSpace(GetMapFieldPropName(aMap)), aRow.Field<object>(aMap.ColumnName).ToString().ToLower());
               }
               else
                  test = string.Format("{0}.{1} = {2};", customName, NameSpaceManager.RemoveNameSpace(GetMapFieldPropName(aMap)), aRow.Field<object>(aMap.ColumnName));

            return test;            
            
        }

        private static String SetNullableValue(DataRow aRow, ColumnMap aMap)
        {
            object dataValue = null;
            if (aRow.Field<object>(aMap.ColumnName) != null)
            {
                switch (aMap.DataType)
                {
                    case "System.Boolean":
                        dataValue = aRow.Field<object>(aMap.ColumnName).ToString().ToLower();
                        break;

                    case "System.Decimal":
                        dataValue = String.Format("(Decimal){0}", aRow.Field<object>(aMap.ColumnName));
                        break;

                    case "System.String":
                        dataValue = String.Format(@"""{0}""", aRow.Field<object>(aMap.ColumnName));
                        break;

                    default:
                        dataValue = aRow.Field<object>(aMap.ColumnName);
                        break;
                }
            }           

            string newValue = "new {0}?({1})";
            if (dataValue != null)
                newValue = string.Format(newValue, aMap.DataType, dataValue);
            else
                newValue = "null";
                        
            return newValue;
        }
        
        private static String SetNullableDateValue(DataRow aRow, ColumnMap aMap)
        {
            object dataValue = aRow.Field<object>(aMap.ColumnName);
            string newValue = @"new {0}?(""{1}"")";
            if (dataValue != null)
                newValue = string.Format(newValue, aMap.DataType, dataValue);
            else
                newValue = "null";

            return newValue;
        }
        /// <summary>
        /// gets field or property name
        /// </summary>
        /// <param name="aMap"></param>
        /// <returns></returns>
        private static String GetMapFieldPropName(ColumnMap aMap)
        {
            string result = String.Empty;
            switch(aMap.GetType().Name)
            {
                case "PropertyColumnMap":
                    result = ((PropertyColumnMap)aMap).PropertyName;
                    break;

                case "FieldColumnMap":
                    result = ((FieldColumnMap)aMap).FieldName;
                    break;
            }

            return result;
        }
    }
}
