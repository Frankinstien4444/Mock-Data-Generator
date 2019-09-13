using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MockDataGenerator.Enums;
using MockDataGenerator.Interfaces;

namespace MockDataGenerator.Controls
{
    public partial class StandardDataTypesCtrl : UserControl
    {
        public ExportEvents.exportControlEventHandler SelectedType;
        public StandardDataTypesCtrl()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateIRuleControl(checkedListBox1.SelectedItem.ToString());
        }

        public void CreateIRuleControl(StandardTypes pickType)
        {
            IRuleControl fieldRuleCtrl = new BaseFieldCtrl();
            FieldTypes generalType = FieldTypes.None;
            dynamic returnType = null;

            switch (pickType)
            {
                case StandardTypes.Boolean:
                    generalType = FieldTypes.Bool;
                    fieldRuleCtrl = new BooleanCtrl();
                    break;

                case StandardTypes.TimeSpan:
                    generalType = FieldTypes.Time;
                    fieldRuleCtrl = new DateTimeFieldCtrl();
                    ((DateTimeFieldCtrl)fieldRuleCtrl).SetRuleDateTimeType(generalType);
                    break;
                case StandardTypes.DateTime:
                    generalType = FieldTypes.Date;
                    fieldRuleCtrl = new DateTimeFieldCtrl();
                    break;

                case StandardTypes.Decimal:
                case StandardTypes.Double:
                case StandardTypes.Int:
                case StandardTypes.Long:
                case StandardTypes.Single:
                    fieldRuleCtrl = new NumberFieldCtrl();
                    generalType = FieldTypes.Number;
                    break;

                case StandardTypes.String:
                    fieldRuleCtrl = new StringFieldCtrl();
                    generalType = FieldTypes.String;
                    break;

                case StandardTypes.Tuple:
                    generalType = FieldTypes.Tuple;
                    returnType = new TupleDialog();
                    break;

                case StandardTypes.Object:
                case StandardTypes.Dynamic:
                    generalType = FieldTypes.Type;
                    ((BaseFieldCtrl)fieldRuleCtrl).SetTitle(pickType);
                    break;

                case StandardTypes.Guid:
                    generalType = FieldTypes.GUID;
                    ((BaseFieldCtrl)fieldRuleCtrl).SetTitle(pickType);
                    break;

                case StandardTypes.Enumerator:
                    fieldRuleCtrl = new EnumeratorCtrl();
                    break;

                case StandardTypes.MappedSource:
                    generalType = FieldTypes.MappedSource;
                    fieldRuleCtrl = new MappedSourceCtrl();
                    break;

                case StandardTypes.InternalList:
                    break;
            }

            if (fieldRuleCtrl != null)
            {
                fieldRuleCtrl.Properties.TypeDisplay = pickType.ToString();
                fieldRuleCtrl.Properties.GeneralType = generalType;
                returnType = fieldRuleCtrl;
            }

            if (SelectedType != null)
                SelectedType(null, new ExportEvents.exportControlEventArgs(returnType));
        }
        public void CreateIRuleControl(String selectedType)
        {
            StandardTypes pickType = (StandardTypes)Enum.Parse(typeof(StandardTypes), selectedType.Replace(" ", ""));
            CreateIRuleControl(pickType);
        }
        
    }
}
