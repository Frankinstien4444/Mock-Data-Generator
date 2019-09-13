using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDataGenerator.SpecialObjects
{
    [Serializable]
    public class GuidRule : BaseRule
    {
        public dynamic GenerateGuid()
        {
            if (ConvertToString)
                return GenerateString();
            else
                return GenerateByes();
        }
        private Guid GenerateByes()
        {
            return Guid.NewGuid();
        }

        private String GenerateString()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
