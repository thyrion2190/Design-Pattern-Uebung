using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FlyweightPatternExample
{
    public interface ITree
    {
        Color GetColor();
        TreeType GetTreeType();
        void DrawTree(int x, int y, int height);
    }
}
