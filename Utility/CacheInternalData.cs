using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using MockDataGenerator.Enums;

namespace MockDataGenerator.Utility
{
    public class CacheInternalData
    {

        public void LoadFile(DataResources sourceType)
        {
            //ResourceManager.GetString(sourceType.ToString());
            var assembly = Assembly.GetExecutingAssembly();
            ResourceManager rm = new ResourceManager("MockDataGenerator.Properties.Resources", assembly);
            MemoryStream loadedSource = new MemoryStream(Encoding.ASCII.GetBytes(rm.GetString(sourceType.ToString())));
            //string resourceName = String.Format("{0}.{1}.txt", applicationResource, sourceType.ToString());            
            //loadedSource = (MemoryStream)assembly.GetManifestResourceStream(resourceName);
            //LoadControl();
        }
    }
}
