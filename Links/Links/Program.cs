using System;

namespace Links;

class Program
{
    public delegate void FuncDelegate(string data);
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter string");
            var str = Console.ReadLine();
            MyClass cls = new MyClass();
            FuncDelegate funcDell =new FuncDelegate(cls.Reverse);
            funcDell += cls.Space;

            Run run = new Run();
            run.runFunc(funcDell, str);
            Console.WriteLine();
            Console.WriteLine();
        }
    }

}
