namespace Composite
{
    public abstract class FileSystemElement
    {
        public FileSystemElement(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public abstract void Draw(int depth);
    }

}
