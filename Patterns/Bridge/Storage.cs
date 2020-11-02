using System.Collections.Generic;

namespace Bridge
{
        public abstract class Storage<T> where T : class
        {
            protected List<T> elements = new List<T>();
            protected ISaveLoad<T> saveLoad;
            public Storage(ISaveLoad<T> saveLoad)
            {
                this.saveLoad = saveLoad;
            }
            public void Add(T element)
            {
                elements.Add(element);
            }
            public void Save(string path)
            {
                saveLoad.Save(elements, path);
            }
            public void Load(string path)
            {
                elements = saveLoad.Load(path);
            }
        }
}
