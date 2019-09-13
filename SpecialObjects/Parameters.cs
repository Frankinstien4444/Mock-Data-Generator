using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildObjects.MapObjects;

namespace MockDataGenerator.SpecialObjects
{
    public class Parameters
    {
        public String ParameterName { set; get; }
        public String DataTypeName { set; get; }

        public Parameters(string paramName, string dataType)
        {
            ParameterName = paramName;
            DataTypeName = dataType;
        }

        public static List<Parameters> ParseString(string[] paramList)
        {
            List<Parameters> result = new List<Parameters>();
            foreach (string aParamSet in paramList)
            {
                string[] parsed = aParamSet.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if(parsed.Length == 2)
                    result.Add(new Parameters(parsed[1], parsed[0]));
            }

            return result;
        }

        public static String[] GetParameterNames(MethodParameterMap aMap)
        {
            string[] results = null;
            if (aMap.ColumnParameterMaps.Count > 0)
                results = aMap.ColumnParameterMaps.Select(x => x.DataType + " " + x.ParameterName).ToArray();
            else if (aMap.ParameterMaps.Count > 0)
                results = aMap.ParameterMaps.Select(x => x.DataType + " " + x.ParameterName).ToArray();

            return results;
        }

        public static String GetParameterValues(object[] parameters)
        {
            return string.Join(", ", from parameter in parameters select parameter.ToString());
        }

        public static String FormParameterMethod(MethodParameterMap aMap)
        {
            string[] paramNames = GetParameterNames(aMap);
            return String.Format("{0}({1})", aMap.MethodName, String.Join(", ", from paramName in paramNames select paramName));
        }
    }
}
