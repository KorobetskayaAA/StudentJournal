using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Students.Model;
using System.Xml.Serialization;
using System.IO;

namespace Students
{
    public static class FileHelper
    {
        public static void SaveToXml(string fileName, Journal journal)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Journal));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                serializer.Serialize(fs, journal);
            }
        }
        public static Journal LoadFromXml(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Journal));
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    return (Journal)serializer.Deserialize(fs);
                }
            }
            catch
            {
                return new Journal();
            }
        }
    }
}
