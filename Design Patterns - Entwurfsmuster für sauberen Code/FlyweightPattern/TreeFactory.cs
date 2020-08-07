using FlyweightPatternExample.Trees;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPatternExample
{
    public class TreeFactory
    {
        public static Dictionary<TreeType, ITree> treeDictionary = new Dictionary<TreeType, ITree>();
        public static ITree GetTree(TreeType treeType)
        {
            if (!treeDictionary.ContainsKey(treeType))
            {
                ITree tree = null;
                switch (treeType)
                {
                    case TreeType.Tanne:
                        tree = new Tanne();
                        Console.WriteLine("Tree with TreeType Tanne was created");
                        break;
                    case TreeType.Ahorn:
                        tree = new Ahorn();
                        Console.WriteLine("Tree with TreeType Ahorn was created");
                        break;
                    case TreeType.Apfelbaum:
                        tree = new Apfelbaum();
                        Console.WriteLine("Tree with TreeType Apfelbaum was created");
                        break;
                    case TreeType.Bananenbaum:
                        tree = new Bananenbaum();
                        Console.WriteLine("Tree with TreeType Bananenbaum was created");
                        break;
                    case TreeType.Birke:
                        tree = new Birke();
                        Console.WriteLine("Tree with TreeType Birke was created");
                        break;
                }

                if(tree == null)
                {
                    throw new Exception("Error 404");
                }
                treeDictionary[treeType] = tree;
            }
            return treeDictionary[treeType];
        }
    }
}
