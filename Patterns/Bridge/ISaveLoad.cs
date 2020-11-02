using System.Collections.Generic;

namespace Bridge
{
        public interface ISaveLoad<T> where T : class
        {
            public void Save(List<T> data,string path);
            public List<T> Load(string path);
        }
}
