using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Folder("Root");

            root.Add(new Folder("Empty Folder"));
            root.Add(new File("Empty File"));

            var subfolder = new Folder("Sub Folder");
            root.Add(subfolder);

            var subsubfolder = new Folder("Sub Sub Folder");
            subfolder.Add(subsubfolder);

            subsubfolder.Add(new File("Some Item"));
            subsubfolder.Add(new File("Another Item"));
            subsubfolder.Add(new File("And Another Item"));
            subsubfolder.Add(new Folder("Some Folder"));

            root.Draw(0);
        }
    }

    public abstract class FileSystemElement
    {
        public FileSystemElement(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public abstract void Draw(int depth);
    }

    public class File : FileSystemElement
    {
        public File(string name) : base(name)
        {}
        public override void Draw(int depth)
        {
            Console.WriteLine(new String('-',depth) + Name);
        }
    }

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
