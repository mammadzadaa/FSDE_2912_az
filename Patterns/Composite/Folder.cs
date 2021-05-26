using System;
using System.Collections.Generic;

namespace Composite
{
    public class Folder : FileSystemElement
    {
        private List<FileSystemElement> elements = new List<FileSystemElement>(); 
        public Folder(string name) : base(name) { }
        public void Add(FileSystemElement element)
        {
            elements.Add(element);
        }
        public void Remove(FileSystemElement element)
        {
            elements.Remove(element);
        }
        public override void Draw(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
            foreach (var item in elements)
            {
                item.Draw(depth + 2);
            }
        }
    }

}
