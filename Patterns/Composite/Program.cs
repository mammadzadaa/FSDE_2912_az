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

}
