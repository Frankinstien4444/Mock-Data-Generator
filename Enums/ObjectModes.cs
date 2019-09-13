using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildObjects.Enums;

namespace MockDataGenerator.Enums
{
    public enum ObjectModes
    {
        None,
        Properties,
        Fields,
        Parameters
    }

    public static class ModeToMapConverter
    {
        public static DataMapType TransFormModeToMapType(ObjectModes aMode)
        {
            DataMapType result = DataMapType.None;

            switch (aMode)
            {
                case ObjectModes.Fields:
                    result = DataMapType.FieldColumnMap;
                    break;

                case ObjectModes.Parameters:
                    result = DataMapType.MethodParameterMap;
                    break;

                case ObjectModes.Properties:
                    result = DataMapType.PropertyColumnMap;
                    break;
            }

            return result;
        }
    }
}
