using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree4 = new Tree("4", null);
            Tree tree5 = new Tree("5", null);
            Tree tree1 = new Tree("1", new List<Tree>() {tree5}.AsEnumerable());
            Tree tree2 = new Tree("2", null);
            Tree tree3 = new Tree("3", new List<Tree>(){ tree1,tree2}.AsEnumerable());

            List<string> names = Tree.GetAllNames(tree3);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            
        }

    }
}
