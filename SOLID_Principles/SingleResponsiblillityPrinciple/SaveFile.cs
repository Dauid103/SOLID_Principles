using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID_Principles.SingleResponsiblillityPrinciple
{
    public class SaveFile
    {
        public void SaveToFile<T>(string directoryPath, string fileName, IEntryManager<T> entry)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), entry.ToString());
            
        }
    }
}
