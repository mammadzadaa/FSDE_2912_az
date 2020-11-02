using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Bridge
{
    public class XmlSaveLoad<T> : ISaveLoad<T> where T : class
    {
        private XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
        public List<T> Load(string path)
        {
            using (FileStream fs = new FileStream(path,FileMode.Open))
            {
                return serializer.Deserialize(fs) as List<T>;
            }
        }

        public void Save(List<T> data, string path)
        {
            
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(fs, data);
            }
        }
    }
}
