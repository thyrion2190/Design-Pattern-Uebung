using System;

namespace DecoratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MacBookPro macBook = new MacBookPro();
            MacBookTouchbar macBookTouchbar = new MacBookTouchbar(macBook);
            MacBookI5Processor macBookI5Processor = new MacBookI5Processor(macBookTouchbar);
            Console.WriteLine(macBookI5Processor.GetDescription());
            Console.WriteLine(macBookI5Processor.GetPrice());
            Console.ReadLine();
        }
    }
}
