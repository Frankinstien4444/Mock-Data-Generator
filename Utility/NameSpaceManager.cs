using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDataGenerator.Utility
{
    public static class NameSpaceManager
    {
        public static String RemoveNameSpace(String className)
        {
            string[] parts = className.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            return parts[parts.Length - 1];
        }
    }
}
