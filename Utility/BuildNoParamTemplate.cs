using BuildObjects.MapObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDataGenerator.Utility
{
    public static class BuildNoParamTemplate
    {
        public static String BuildTemplate(string customName, DataRow aRow, ColumnMap aMap)
        {
            string output = String.Empty;

            if (aMap.IsNullable)
            {
                if (aMap.DataType.Contains("DateTime?") || aMap.DataType.Contains("String?"))
                {
                    output = string.Format(@"{0}.{1} = {2};", customName, NameSpaceManager.RemoveNameSpace(ExtractStoreData.GetMapFieldPropName(aMap)), ExtractStoreData.SetNullableDateValue(aRow, aMap));
                }
                else
                    output = string.Format("{0}.{1} = {2};", customName, NameSpaceManager.RemoveNameSpace(ExtractStoreData.GetMapFieldPropName(aMap)), ExtractStoreData.SetNullableValue(aRow, aMap));
            }
            else if (aMap.DataType.Contains("String"))
            {
                string value = aRow.Field<string>(aMap.ColumnName);
                if (value != null)
                    value = value.Trim();
                output = string.Format(@"{0}.{1} = ""{2}"";", customName, NameSpaceManager.RemoveNameSpace(ExtractStoreData.GetMapFieldPropName(aMap)), value);
            }
            else if (aMap.DataType.Contains("DateTime"))
                output = string.Format(@"{0}.{1} = DateTime.Parse(""{2}"");", customName, NameSpaceManager.RemoveNameSpace(ExtractStoreData.GetMapFieldPropName(aMap)), aRow.Field<object>(aMap.ColumnName));
            else if (aMap.DataType.Contains("Guid"))
            {
                output = string.Format(@"{0}.{1} = Guid.ParseExact(""{2}"");", customName, NameSpaceManager.RemoveNameSpace(ExtractStoreData.GetMapFieldPropName(aMap)), aRow.Field<object>(aMap.ColumnName));
            }
            else if (aMap.DataType.Contains("Boolean"))
            {
                object value = aRow.Field<object>(aMap.ColumnName);
                if (value != null)
                    value = value.ToString().ToLower();
                output = string.Format("{0}.{1} = {2};", customName, NameSpaceManager.RemoveNameSpace(ExtractStoreData.GetMapFieldPropName(aMap)), value);
            }
            else
                output = string.Format("{0}.{1} = {2};", customName, NameSpaceManager.RemoveNameSpace(ExtractStoreData.GetMapFieldPropName(aMap)), aRow.Field<object>(aMap.ColumnName));

            return output;

        }
    }
}
