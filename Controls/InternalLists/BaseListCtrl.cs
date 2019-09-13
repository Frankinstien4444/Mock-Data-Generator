using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MockDataGenerator.Enums;
using System.Reflection;
using MockDataGenerator.Interfaces;
using System.Resources;
using MockDataGenerator.Properties;

namespace MockDataGenerator.Controls.InternalLists
{
    public partial class BaseListCtrl : AbstractRuleControl
    {
        public DataResources SourceType { set; get; }
        protected MemoryStream loadedSource;
        protected const string applicationResource = "MockDataGenerator.Properties.Resources"; //.Properties.Resources
        protected string[] fileLines;
        protected int pageSize = 20;
        protected long currentPosition = 0;
        public BaseListCtrl()
        {
            InitializeComponent();
        }

        public void LoadFile(DataResources sourceType)
        {
            //ResourceManager.GetString(sourceType.ToString());
            var assembly = Assembly.GetExecutingAssembly();
            ResourceManager rm = new ResourceManager("MockDataGenerator.Properties.Resources", assembly);
            loadedSource = new MemoryStream(Encoding.ASCII.GetBytes(rm.GetString(sourceType.ToString())));
            //string resourceName = String.Format("{0}.{1}.txt", applicationResource, sourceType.ToString());            
            //loadedSource = (MemoryStream)assembly.GetManifestResourceStream(resourceName);
            LoadControl();
        }

        public virtual void LoadControl()
        {
            using (loadedSource)
            {
                using (StreamReader readFile = new StreamReader(loadedSource))
                {
                    char[] CRLF = new char[2] { '\n', '\r' };
                    fileLines = readFile.ReadToEnd().Split(CRLF, StringSplitOptions.RemoveEmptyEntries);
                }
            }
        }

        protected virtual void LoadRecords()
        {
            throw new Exception("not implemented in base class");
        }
        
    }
}
