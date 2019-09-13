using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDataGenerator.Utility
{
    public class PageOffsetList : IListSource
    {
        public  int TotalRecords { set; private get; }
        public int PageSize { set; private get; }
        public bool ContainsListCollection { get; protected set; }

        public System.Collections.IList GetList()
        {
            // Return a list of page offsets based on "totalRecords" and "pageSize"
            var pageOffsets = new List<int>();
            for (int offset = 0; offset < TotalRecords; offset += PageSize)
                pageOffsets.Add(offset);
            return pageOffsets;
        }
    }
}
