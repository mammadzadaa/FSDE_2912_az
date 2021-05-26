using System;

namespace Composite
{
    public class File : FileSystemElement
    {
        public File(string name) : base(name)
        {}
        public override void Draw(int depth)
        {
            Console.WriteLine(new String('-',depth) + Name);
        }
    }

}
