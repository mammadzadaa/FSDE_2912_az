using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Bridge
{
        public class JsonSaveLoad<T> : ISaveLoad<T> where T : class
        {
            public List<T> Load(string path)
            {
               return JsonSerializer.Deserialize<List<T>>(File.ReadAllText(path));
            }

            public void Save(List<T> data, string path)
            {
                File.WriteAllText(path, JsonSerializer.Serialize(data));
            }
        }
    
}
