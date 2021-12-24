using System;

namespace CSharpCource
{
    class Program
    {
        static void Main(string[] args)
        {
            static void MyFunction()
            {
                Console.WriteLine("Hello World!");
                string myString = "my friend!";
                Console.WriteLine(myString);
                int x = 1;
                int j = x++;
                Console.WriteLine(j + " and " + x);
                x--;
                j = ++x;
                Console.WriteLine(j + " and " + x);
                Console.Read();
            }
            
        }
        
    }
}
