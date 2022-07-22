using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    public class Tree

    {

        public string Name { get; set; }

        public IEnumerable<Tree> Children { get; set; }

        public Tree(string name, IEnumerable<Tree> children)
        {
            Name = name;
            Children = children;
        }

        public static List<string> GetAllNames(Tree tree)
        { 
            List<string> nameList = new List<string>();
            RecurcyFuncGetNameInTrees(nameList, tree);
            return nameList;
            
        }

        private static void RecurcyFuncGetNameInTrees(List<string> nameList, Tree tree)
        {
            nameList.Add(tree.Name);
            if (tree.Children != null)
            {                
                foreach (Tree child in tree.Children)
                {                    
                    RecurcyFuncGetNameInTrees(nameList,child);
                }
            } 
        }

    }
    
}
