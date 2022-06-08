using System;

namespace Composite
{
    class Program
    {
        static void Main()
        {
            Component root = new Catalog("DiskC");
            Component branch1 = new Catalog("MyHomework");
            Component branch2 = new Catalog("Labs");
            Component leaf1 = new File("EnglishProject.pdf", 230);
            Component leaf2 = new File("Lab_1.docx", 144);
            Component leaf3 = new File("EnglishBook.pdf", 1200);
            Component branch3 = new Catalog("Lessons");

            root.Add(branch1);
            root.Add(branch2);
            branch1.Add(leaf1);
            branch1.Add(leaf3);
            branch2.Add(leaf2);
            branch1.Add(branch3);
            branch3.Add(leaf3);

            root.Operation();

            branch2.GetChild(0).Operation();

            try
            {
                leaf3.Add(leaf1);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("You cann`t add to files any catalog or file!");
            }

            Console.WriteLine(branch1.Size);
        }
    }
}
