using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FlyweightPatternExample
{
    public class Tanne : ITree
    {
        private Color color;
        private TreeType treeType;

        public Tanne()
        {
            this.color = Color.Brown;
            this.treeType = TreeType.Tanne;
        }
        public void DrawTree(int x, int y, int height)
        {
            Console.WriteLine("The {0} was spawned on position: x Cordinate: {1} and y Cordinate: {2}. The height of the {0} is {3} Meter.", this.treeType, x, y, height);
        }

        public Color GetColor()
        {
            return color;
        }

        public TreeType GetTreeType()
        {
            return treeType;
        }
    }
}
