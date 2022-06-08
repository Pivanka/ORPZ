using System;

namespace Composite
{
    interface Component
    {
        string Name { get; set; }
        int Size { get; set; }
        void Operation();
        void Add(Component component);
        void Remove(Component component);
        Component GetChild(int index);
    }
}
