using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // var a = new a1<int>(2);
            // a.print();


            var intstack = new stack<int>();
            
            intstack.Push(1);
            intstack.Push(1);
            intstack.Push(1);
            
            int x = intstack.Pop();
            
            Console.WriteLine(x);



        }
    }
}