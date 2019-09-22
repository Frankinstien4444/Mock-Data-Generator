using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildObjects.MapObjects;

namespace MockDataGenerator.UIServices
{
    public static class MapTo
    {
        public static void MapToProperties(ListViewItem aItem, MapedObject aMap, bool ruleBased)
        {
            PropertyColumnMap aPair = new PropertyColumnMap();
            if (!ruleBased)
                aPair.ColumnName = aItem.SubItems[0].Text;
            else
                aPair.ColumnName = aItem.SubItems[1].Text;
            aPair.RuleBased = ruleBased;
            aPair.PropertyName = aItem.SubItems[1].Text;
            aPair.DataType = aItem.SubItems[2].Text;
            aPair.IsNullable = bool.Parse(aItem.SubItems[4].Text);
            aMap.PropMaps.Add(aPair);
        }

        public static void MapToFields(ListViewItem aItem, MapedObject aMap, bool ruleBased)
        {
            FieldColumnMap aPair = new FieldColumnMap();
            if(!ruleBased)
                aPair.ColumnName = aItem.SubItems[0].Text;
            else
                aPair.ColumnName = aItem.SubItems[1].Text;
            aPair.RuleBased = ruleBased;
            aPair.FieldName = aItem.SubItems[1].Text;
            aPair.DataType = aItem.SubItems[2].Text;
            aPair.IsNullable = bool.Parse(aItem.SubItems[4].Text);
            aMap.FieldMaps.Add(aPair);
        }

        public static MethodParameterMap MapToParameters(ListViewItem aItem, MapedObject aMap, String methodName, int parameterCount, Guid id, bool ruleBased)
        {
            ParameterMap aRuleField = new ParameterMap();
            aRuleField.DataType = aItem.SubItems[2].Text;
            aRuleField.IsNullable = bool.Parse(aItem.SubItems[4].Text);
            aRuleField.ParameterName = aItem.SubItems[1].Text;
            aRuleField.RuleBased = ruleBased;
            return AddParameterMap(aMap, aRuleField, methodName, id, parameterCount);
        }

        public static MethodParameterMap MapToParameterColumnMap(ListViewItem aItem, MapedObject aMap, String methodName, int parameterCount, bool ruleBased, Guid id)
        {
            ParameterColumnMap aPair = new ParameterColumnMap();
            if(!ruleBased)
                aPair.ColumnName = aItem.SubItems[0].Text;
            else
                aPair.ColumnName = aItem.SubItems[1].Text;
            aPair.RuleBased = ruleBased;
            aPair.ParameterName = aItem.SubItems[1].Text;
            aPair.DataType = aItem.SubItems[2].Text;
            aPair.IsNullable = bool.Parse(aItem.SubItems[4].Text);
            return AddParameterMap(aMap, aPair, methodName, id, parameterCount);
        }

        private static MethodParameterMap AddParameterMap(MapedObject aMap, InfoMap aPair, String methodName, Guid id, int paramCount)
        {
            var methodParams = aMap.MethodParameters.Where(x => x.MethodName.Equals(methodName) && x.ID == id).FirstOrDefault();
            if (methodParams == null)
            {
                methodParams = new MethodParameterMap();
                methodParams.MethodName = methodName;
                methodParams.ParameterCount = paramCount;
                if (aPair.RuleBased)
                    methodParams.ParameterMaps.Add((ParameterMap)aPair);
                else
                    methodParams.ColumnParameterMaps.Add((ParameterColumnMap)aPair);
                aMap.MethodParameters.Add(methodParams);
            }
            else if (aPair.RuleBased)
                methodParams.ParameterMaps.Add((ParameterMap)aPair);
            else if (!aPair.RuleBased)
                methodParams.ColumnParameterMaps.Add((ParameterColumnMap)aPair);

            return methodParams;
        }
    }
}
