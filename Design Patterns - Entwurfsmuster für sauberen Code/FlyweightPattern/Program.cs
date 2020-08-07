using System;

namespace FlyweightPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ITree ahorn = TreeFactory.GetTree(TreeType.Ahorn);
            ahorn.DrawTree(4, 5, 6);
            ITree apfelbaum = TreeFactory.GetTree(TreeType.Apfelbaum);
            apfelbaum.DrawTree(854, 542, 13);
            ITree bananenbaum = TreeFactory.GetTree(TreeType.Bananenbaum);
            bananenbaum.DrawTree(10, 20, 30);
            ITree birke = TreeFactory.GetTree(TreeType.Birke);
            birke.DrawTree(1, 2, 3);
            ITree tanne = TreeFactory.GetTree(TreeType.Tanne);
            tanne.DrawTree(45, 13, 53);
            ITree ahorn1 = TreeFactory.GetTree(TreeType.Ahorn);
            ahorn1.DrawTree(14, 15, 16);
            ITree ahorn2 = TreeFactory.GetTree(TreeType.Ahorn);
            ahorn2.DrawTree(24, 25, 26);
            ITree ahorn3 = TreeFactory.GetTree(TreeType.Ahorn);
            ahorn3.DrawTree(34, 35, 36);
            ITree apfelbaum1 = TreeFactory.GetTree(TreeType.Apfelbaum);
            apfelbaum1.DrawTree(687, 132, 18);
            ITree apfelbaum2 = TreeFactory.GetTree(TreeType.Apfelbaum);
            apfelbaum2.DrawTree(164, 768, 21);
            ITree apfelbaum3 = TreeFactory.GetTree(TreeType.Apfelbaum);
            apfelbaum3.DrawTree(489, 451, 12);
            ITree bananenbaum1 = TreeFactory.GetTree(TreeType.Bananenbaum);
            bananenbaum1.DrawTree(496, 276, 30);
            ITree bananenbaum2 = TreeFactory.GetTree(TreeType.Bananenbaum);
            bananenbaum2.DrawTree(141, 798, 30);
            ITree bananenbaum3 = TreeFactory.GetTree(TreeType.Bananenbaum);
            bananenbaum3.DrawTree(116, 278, 30);
            ITree birke1 = TreeFactory.GetTree(TreeType.Birke);
            birke1.DrawTree(11, 12, 13);
            ITree birke2 = TreeFactory.GetTree(TreeType.Birke);
            birke2.DrawTree(21, 22, 23);
            ITree birke3 = TreeFactory.GetTree(TreeType.Birke);
            birke3.DrawTree(31, 32, 33);
            ITree tanne1 = TreeFactory.GetTree(TreeType.Tanne);
            tanne1.DrawTree(789, 465, 53);
            ITree tanne2 = TreeFactory.GetTree(TreeType.Tanne);
            tanne2.DrawTree(445, 347, 53);
            ITree tanne3 = TreeFactory.GetTree(TreeType.Tanne);
            tanne3.DrawTree(865, 183, 53);
            Console.ReadLine();
        }
    }
}
