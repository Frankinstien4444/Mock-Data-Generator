﻿using BuildObjects.MapObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDataGenerator.Utility
{
    public static class BuildParameterTemplate
    {
        public static String BuildTemplate(DataRow aRow, ColumnMap aMap)
        {
            string output = String.Empty;
            if (aMap.IsNullable)
            {
                if (aMap.DataType.Contains("DateTime?") || aMap.DataType.Contains("String?"))
                {
                    output = string.Format(@"{0},", ExtractStoreData.SetNullableDateValue(aRow, aMap));
                }
                else
                    output = string.Format("{0},", ExtractStoreData.SetNullableValue(aRow, aMap));
            }
            else if (aMap.DataType.Contains("String"))
                output = string.Format(@"""{0}"",", aRow.Field<string>(aMap.ColumnName).Trim());
            else if (aMap.DataType.Contains("DateTime"))
                output = string.Format(@"DateTime.Parse(""{0}""),", aRow.Field<object>(aMap.ColumnName));
            else if (aMap.DataType.Contains("Guid"))
            {
                output = string.Format(@"Guid.ParseExact(""{0}""),", aRow.Field<object>(aMap.ColumnName));
            }
            else if (aMap.DataType.Contains("Boolean"))
            {
                output = string.Format("{0},", aRow.Field<object>(aMap.ColumnName).ToString().ToLower());
            }
            else
                output = string.Format("{0},", aRow.Field<object>(aMap.ColumnName));
            return output;
        }
    }
}