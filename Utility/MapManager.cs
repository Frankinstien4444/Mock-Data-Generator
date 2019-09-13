using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildObjects.Enums;
using BuildObjects.MapObjects;
using MockDataGenerator.Enums;
using MockDataGenerator.Interfaces;
using MockDataGenerator.SpecialObjects;
using MockDataGenerator.UIServices;

namespace MockDataGenerator.Utility
{
    public static class MapManager
    {
        public static DataStore FindStore(List<DataStore> stores, ObjectModes currentMode, string methodName, int paramCount)
        {
            DataStore result = null;

            switch (currentMode)
            {
                case ObjectModes.Fields:
                    result = stores.Where(x => x.MapType.Equals(DataMapType.FieldColumnMap)).FirstOrDefault();

                    break;

                case ObjectModes.Properties:
                    result = stores.Where(x => x.MapType.Equals(DataMapType.PropertyColumnMap)).FirstOrDefault();
                    break;
                
                case ObjectModes.Parameters:
                    result = stores.Where(x => x.MapType.Equals(DataMapType.MethodParameterMap) && x.DataStoreName.Equals(methodName) && x.ActualData.Columns.Count.Equals(paramCount)).FirstOrDefault();
                    break;
            }

            return result;
        }

        public static bool FindStoreAndUpdate(List<DataStore> stores, ObjectModes currentMode, string methodName, DataTable queryResult)
        {
            DataStore result = null;            

            switch (currentMode)
            {
                case ObjectModes.Fields:
                    result = stores.Where(x => x.MapType.Equals(DataMapType.FieldColumnMap)).FirstOrDefault();
                    if (result == null)
                    {
                        result = new DataStore();
                        result.ActualData = queryResult;
                        result.DataStoreName = DataMapType.FieldColumnMap.ToString();
                        result.MapType = DataMapType.FieldColumnMap;
                        stores.Add(result);
                    }
                    break;

                case ObjectModes.Properties:
                    result = stores.Where(x => x.MapType.Equals(DataMapType.PropertyColumnMap)).FirstOrDefault();
                    if (result == null)
                    {
                        result = new DataStore();
                        result.ActualData = queryResult;
                        result.DataStoreName = DataMapType.PropertyColumnMap.ToString();
                        result.MapType = DataMapType.PropertyColumnMap;
                        stores.Add(result);
                    }
                    break;
                
                case ObjectModes.Parameters:
                    result = stores.Where(x => x.MapType.Equals(DataMapType.MethodParameterMap) && x.DataStoreName.Equals(methodName) && x.ActualData.Columns.Count.Equals(queryResult.Columns.Count)).FirstOrDefault();
                    if (result == null)
                    {
                        result = new DataStore();
                        result.ActualData = queryResult;
                        result.DataStoreName = methodName;
                        result.MapType = DataMapType.MethodParameterMap;
                        stores.Add(result);
                    }
                    break;
            }

            if (result != null)
            {
                result.ActualData = queryResult;
                return true;              
            }

            return false;
        }

        public static RuleStore FindRule(string dataStoreName, ReferenceData aRef)
        {
            var rule = aRef.StoreReferences.Where(x => x.DataStoreName.Equals(dataStoreName) && x.GetType().Equals(typeof(RuleStore))).FirstOrDefault();
            if (rule != null)
                return (RuleStore)rule;

            return null;
        }

        public static SQLStore FindSQL(string dataStoreName, ReferenceData aRef)
        {
            var sql = aRef.StoreReferences.Where(x => x.DataStoreName.Equals(dataStoreName) && x.GetType().Equals(typeof(SQLStore))).FirstOrDefault();
            if (sql != null)
                return (SQLStore)sql;

            return null;
        }

        public static RuleStore FindRule(string dataStoreName, int paramCount, ReferenceData aRef)
        {
            var rule = aRef.StoreReferences.Where(x => x.DataStoreName.Equals(dataStoreName) && x.ParamterCount.Equals(paramCount) && x.GetType().Equals(typeof(RuleStore))).FirstOrDefault();
            if (rule != null)
                return (RuleStore)rule;

            return null;
        }

        public static String GetSQL(string dataStoreName, ReferenceData aRef)
        {
            var sql = aRef.StoreReferences.Where(x => x.DataStoreName.Equals(dataStoreName) && x.GetType().Equals(typeof(SQLStore))).FirstOrDefault();
            if (sql != null)
                return ((SQLStore)sql).SQL;
            return String.Empty;
        }
        public static String GetSQL(string dataStoreName, ReferenceData aRef, int paramCount)
        {
            var sql = aRef.StoreReferences.Where(x => x.DataStoreName.Equals(dataStoreName) && x.ParamterCount.Equals(paramCount) && x.GetType().Equals(typeof(SQLStore))).FirstOrDefault();
            if (sql != null)
                return ((SQLStore)sql).SQL;
            return String.Empty;
        }


        public static BaseStore FindStore(string dataStoreName, int paramCount, ReferenceData aRef)
        {
            var store = aRef.StoreReferences.Where(x => x.DataStoreName.Equals(dataStoreName) && x.ParamterCount.Equals(paramCount)).FirstOrDefault();
            return store;
        }
                
        public static void FindSQLAndUpdate(string dataStoreName, int paramCount, ReferenceData aRef, string sql)
        {
            var aSql = aRef.StoreReferences.Where(x => x.DataStoreName.Equals(dataStoreName) && x.ParamterCount.Equals(paramCount) && x.GetType().Equals(typeof(SQLStore))).FirstOrDefault();
            if (aSql == null)
            {
                SQLStore nSql = new SQLStore();
                nSql.DataStoreName = dataStoreName;
                nSql.SQL = sql;
                nSql.ParamterCount = paramCount;
                aRef.StoreReferences.Add(nSql);                
            }
            else
                ((SQLStore)aSql).SQL = sql;
        }

        public static void FindRuleAndUpdate(string dataStoreName, ReferenceData aRef, List<IDataRule> rules, DataMapType mapType)
        {
            int paramCount = rules.Count;
            var aRule = aRef.StoreReferences.Where(x => x.DataStoreName.Equals(dataStoreName) && x.ParamterCount.Equals(paramCount) && x.GetType().Equals(typeof(RuleStore))).FirstOrDefault();
            if (aRule == null)
            {
                RuleStore nRule = new RuleStore();
                nRule.DataStoreName = dataStoreName;
                nRule.Rules = rules;
                nRule.MapType = mapType;
                nRule.ParamterCount = paramCount;
                aRef.StoreReferences.Add(nRule);                
            }
            else
                ((RuleStore)aRule).Rules = rules;
        }

        public static void FindSQLAndUpdate(string dataStoreName, ReferenceData aRef, string sql)
        {
            var aSql = aRef.StoreReferences.Where(x => x.DataStoreName.Equals(dataStoreName) && x.GetType().Equals(typeof(SQLStore))).FirstOrDefault();
            if (aSql == null)
            {
                SQLStore nSql = new SQLStore();
                nSql.DataStoreName = dataStoreName;
                nSql.SQL = sql;
                aRef.StoreReferences.Add(nSql);
            }
            else
                ((SQLStore)aSql).SQL = sql;
        }
        
        public static void FindOrCreateMap(TreeView projectView, string className, ref MapedObject aMapObject)
        {
            MapReferences refInfo;
            if (Mapped.FindMap(projectView, className, out refInfo))
                aMapObject = refInfo.ViableInfo.TheMap;
            else
            {
                aMapObject = new MapedObject();
                aMapObject.ClassName = className;
            }
        }

        public static DataTable FindQueryInfo(List<DataStore> aStore, string methodName, ObjectModes currentMode, int paramCount, out string storeName)
        {
            storeName = String.Empty;
            DataStore result = MapManager.FindStore(aStore, currentMode, methodName, paramCount);
            if (result == null) return null;

            storeName = result.DataStoreName;
            return result.ActualData;
        }        
    }
}
