using System;
using System.Collections.Generic;
using BuildObjects.MapObjects;
using MockDataGenerator.Enums;
using MockDataGenerator.Interfaces;
using MockDataGenerator.SpecialObjects;
using MockDataGenerator.SpecialObjects.Rules;
using MockDataGenerator.SpecialObjects.Rules.RuleSupport;

namespace MockDataGenerator.Utility
{
    public static class BuildRules
    {
        public static IDataRule InitializeBase(FieldTypes generalType, bool isRandom, String fieldName, String fieldDataType, bool convertToString)
        {
            IDataRule result = null;

            switch (generalType)
            {
                case FieldTypes.Date:
                    result = new DateRule();
                    break;

                case FieldTypes.Time:
                    result = new TimeRule();
                    break;

                case FieldTypes.GUID:
                    result = new GuidRule();
                    break;

                case FieldTypes.Imported:
                    //result = new 
                    break;

                case FieldTypes.MultiColumn:
                    result = new MultiFieldDataSourceRule();
                    break;

                case FieldTypes.SingleColumn:
                    result = new SingleFieldDataSourceRule();
                    break;

                case FieldTypes.Number:
                    result = new NumberRule();
                    break;

                case FieldTypes.String:
                    result = new StringRule();
                    break;

                case FieldTypes.Bool:
                    result = new BoolRule();
                    break;

                case FieldTypes.Dynamic:
                case FieldTypes.Type:
                    result = new TRule();
                    break;

                case FieldTypes.Enumerator:
                    result = new EnumeratorRule();
                    break;

                case FieldTypes.MappedSource:
                    result = new MappedSourceRule();
                    break;

                case FieldTypes.Collection:
                    result = new CollectionRule();
                    break;

                case FieldTypes.Tuple:
                    result = new TupleRule();
                    break;
            }

            result.ConvertToString = convertToString;
            result.FieldDataType = fieldDataType;
            result.FieldName = fieldName;
            result.IsRandom = isRandom;
            result.RuleType = generalType;            
            return result;
        }

        public static void Buildrule(StringRule aRule, bool isRandomPosition, String stringLength, string[] entries)
        {
            aRule.Entries = new List<string>(entries);            
            aRule.RandomPosition = isRandomPosition;
            int result = -1;
            if (int.TryParse(stringLength, out result))
                aRule.StringLength = result;
            else
                throw new Exception("Build string rule failed");
        }

        public static void Buildrule(NumberRule aRule, string start, string end, string increment)
        {
            double result = double.NegativeInfinity;

            if (double.TryParse(start, out result))
                aRule.Start = result;
            else
                throw new Exception("Build number rule failed for start field");

            if (double.TryParse(end, out result))
                aRule.End = result;
            else
                throw new Exception("Build number rule failed for end field");

            if (double.TryParse(increment, out result))
                aRule.Increment = result;
            else
                throw new Exception("Build number rule failed for increment field");
        }

        public static void Buildrule(SingleFieldDataSourceRule aRule, DataResources typeofInternalSource, int maxRecs, string startRange, string endRange, string regularExpression)
        {
            try
            {
                aRule.RangeStart = startRange;
                aRule.RangeEnd = endRange;
                aRule.RegularExpression = regularExpression;
                aRule.MaxRecords = maxRecs;
            }
            catch(Exception e)
            {
                throw new Exception("Build SingleFieldDataSource rule failed");
            }
        }

        public static void Buildrule(MultiFieldDataSourceRule aRule, DataResources typeofInternalSource, int maxRecs, List<SearchField> selected, List<DataField> fieldDataMap, ListCtrlType ctrlType)
        {
            try
            {
                aRule.TypeofInternalSource = typeofInternalSource;
                aRule.SearchFields = selected;
                aRule.FieldColumnMap = fieldDataMap;
                aRule.MaxRecords = maxRecs;                
                aRule.SearchFields = selected;
            }
            catch(Exception e)
            {
                throw new Exception("Build MultiField rule failed");
            }    
            
        }

        public static void Buildrule(GuidRule aRule)
        {
            
        }

        public static void Buildrule(BoolRule aRule, bool alwaysTrue, bool alwaysFalse)
        {
            aRule.AlwaysFalse = alwaysFalse;
            aRule.AlwaysTrue = alwaysTrue;
        }

        public static void Buildrule(TimeRule aRule, DateTime start, DateTime end, String increment, String rateType)
        {
            try
            {
                aRule.Start = start;
                aRule.End = end;
                double result = Double.NegativeInfinity;
                if (double.TryParse(increment, out result))
                    aRule.Increment = result;
                else
                    throw new Exception();

                aRule.RateType = EnumPlus.ConvertString(typeof(DateTimeRateTypes), rateType);
            }
            catch (Exception e)
            {
                throw new Exception("Build time rule failed");
            }

        }

        public static void Buildrule(DateRule aRule, DateTime start, DateTime end, String increment, String rateType)
        {
            try
            {
                aRule.Start = start;
                aRule.End = end;
                double result = Double.NegativeInfinity;
                if (double.TryParse(increment, out result))
                    aRule.Increment = result;
                else
                    throw new Exception();

                aRule.RateType = EnumPlus.ConvertString(typeof(DateTimeRateTypes), rateType);
            }
            catch (Exception e)
            {
                throw new Exception("Build date rule failed");
            }
        }

        public static void Buildrule(CollectionRule aRule, String genericType, IDataRule valueRule, IDataRule keyRule, String assembly, String assemblyPath)
        {
            aRule.Assembly = assembly;
            aRule.Assembly = assemblyPath;
            aRule.Generic = EnumPlus.ConvertString(typeof(GenericCollections), genericType); 
            aRule.ValueRule = valueRule;
            aRule.KeyRule = keyRule;
        }

        public static void Buildrule(EnumeratorRule aRule, bool isRandom, String enumType, String assemblyName)
        {
            aRule.IsRandom = isRandom;
            aRule.Enumerator = enumType;
            aRule.Assembly = assemblyName;
        }

        public static void Buildrule(MappedSourceRule aRule, ViableMapAndData mappedSource)
        {
            aRule.MappedSource = mappedSource;
        }

        public static void Buildrule(TupleRule aRule, List<IDataRule> rules)
        {
            aRule.Types = rules;
        }

    }
}
