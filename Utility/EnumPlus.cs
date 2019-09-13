using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDataGenerator.Utility
{
    public static class EnumPlus 
    {
        public static bool CompareEnumValue(Enum enumValue, int value)
        {
          return CompareEnumValue(enumValue, value.ToString());
        }
        public static bool CompareEnumValue(Enum enumValue, String value)
        {
            bool result = false;
            int numberValue = -1;
            try
            {
                value = value.Trim();
                if (!String.IsNullOrEmpty(value))
                {
                    if (int.TryParse(value, out numberValue))
                    {
                        var newValue = Convert.ChangeType(enumValue, typeof(int));
                        result = numberValue.Equals(newValue);
                    }
                    else
                    {
                        var newValue = Convert.ChangeType(Enum.Parse(enumValue.GetType(), value, true), enumValue.GetType());
                        result = enumValue.Equals(newValue);
                    }
                }
            }
            catch { }
            return result;
        }

        public static dynamic ConvertString(Type enumType, string value)
        {
            try
            {
                value = value.Trim();
                if (!String.IsNullOrEmpty(value))
                {
                    return Convert.ChangeType(Enum.Parse(enumType, value, true), enumType);
                }
            }
            catch { }
            return null;
        }
    }
}
