using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MockDataGenerator.SpecialObjects;

namespace MockDataGenerator.Interfaces
{
    public interface IRuleControl
    {
       CommonCtrlProperies Properties { set; get; }
       bool ApplyDataToRuleSet();
       void EditRule(IDataRule aRue);
    }
}
