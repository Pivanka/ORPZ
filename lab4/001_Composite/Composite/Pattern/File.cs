using System;

namespace Composite
{
    class File : Component
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public File(string name, int size)
            : base()
        {
            Name = name;
            Size = size;
        }

        public void Operation()
        {
            Console.WriteLine(Name);
        }

        public void Add(Component component)
        {
            throw new InvalidOperationException();
        }

        public void Remove(Component component)
        {
            throw new InvalidOperationException();
        }

        public Component GetChild(int index)
        {
            throw new InvalidOperationException();
        }
    }
}
