using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildObjects.MapObjects;
using MockDataGenerator.SpecialObjects;

namespace MockDataGenerator.Utility
{
    public class RuleDataGenerator
    {
        public void CreateDataTable(RuleStore rules, DataStore store)
        {
            store.ActualData = new DataTable();
            int maxRows = 0;
            foreach(BaseRule aRule in rules.Rules)
            {
                if (aRule.MaxRecords > maxRows)
                    maxRows = aRule.MaxRecords;
                DataColumn newColumn = new DataColumn(aRule.FieldName, Type.GetType(aRule.FieldDataType));
                store.ActualData.Columns.Add(newColumn);
            }

            for (int row = 0; row < maxRows; row++)
            {
                DataRow newRow = store.ActualData.NewRow();
                store.ActualData.Rows.Add(newRow);
            }
        }
        public void GenerateData(NumberRule rule, DataStore store)
        {
            Random generateRandom = new Random();
            DataColumn aColumn = store.ActualData.Columns[rule.FieldName];
            int counter = -1;
            double range = rule.End - rule.Start;
            foreach (DataRow aRow in store.ActualData.Rows)
            {
                counter++;
                double result = -1;
                if (rule.IsRandom)
                {
                    result = rule.Start + generateRandom.NextDouble() * range;
                }
                else
                {
                    result = rule.Start + counter * rule.Increment;
                    if(result > rule.End)
                    {
                        counter = 0;
                        result = rule.Start;
                    }
                }
                if(rule.ConvertToString)
                    aRow.ItemArray[aColumn.Ordinal] = result.ToString();
                else
                    aRow.ItemArray[aColumn.Ordinal] = result;
            }
        }


        public void GenerateData(StringRule rule, DataStore store)
        {
            
            DataColumn aColumn = store.ActualData.Columns[rule.FieldName];
            if (rule.IsRandom)
            {
                RandomStringPick(rule, store, aColumn.Ordinal);
            }
            else if(rule.RandomPosition)
            {
                RandomStringPosition(rule, store, aColumn.Ordinal);
            }
            else
            {
                int counter = -1;
                foreach (DataRow aRow in store.ActualData.Rows)
                {
                    counter++;
                    if (counter == rule.Entries.Count)
                        counter = 0;
                    aRow.ItemArray[aColumn.Ordinal] = rule.Entries[counter];
                }
            }
        }

        private void RandomStringPosition(StringRule rule, DataStore store, int colIndex)
        {
            String result = String.Empty;
            int range = rule.Entries[0].Length - rule.StringLength;
            Random randomGenerator = new Random();
            foreach (DataRow aRow in store.ActualData.Rows)
            {
                int randomChar = randomGenerator.Next(0, range);
                result = rule.Entries[0].Substring(randomChar, rule.StringLength);
                aRow.ItemArray[colIndex] = result;
            }
        }

        private void RandomStringPick(StringRule rule, DataStore store, int colIndex)
        {
            String result = String.Empty;
            char[] alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] alphabetLower = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
            List<char> allLetters = new List<char>();
            allLetters.AddRange(alphabetLower);
            allLetters.AddRange(alphabetUpper);
            int range = allLetters.Count;
            Random randomGenerator = new Random();
            foreach (DataRow aRow in store.ActualData.Rows)
            {
                for (int x = 0; x < rule.StringLength; x++)
                {
                    int randomChar = randomGenerator.Next(0, range);
                    result = result + allLetters[randomChar].ToString();
                }
                aRow.ItemArray[colIndex] = result;
            }
        }
    }
}
