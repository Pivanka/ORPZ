using System;
using System.Collections;

namespace Composite
{
    class Catalog : Component
    {
        ArrayList nodes = new ArrayList();
        int size;

        public string Name { get; set; }
        public int Size 
        {
            get
            {
                foreach (Component component in nodes)
                {
                    if (component is File)
                    {
                        size += ((File)component).Size;
                    }
                    else
                    {
                        size += component.Size;
                    }
                }
                return size;
            }
            set
            {
            }
        }

        public Catalog(string name)
            :base()
        {
            Name = name;
            this.size = 0;
        }

        public void Operation()
        {
            Console.WriteLine(Name);

            foreach (Component component in nodes)
                component.Operation();
        }

        public void Add(Component component)
        {
            nodes.Add(component);
        }

        public void Remove(Component component)
        {
            nodes.Remove(component);
        }

        public Component GetChild(int index)
        {
            return nodes[index] as Component;
        }

    }
}
