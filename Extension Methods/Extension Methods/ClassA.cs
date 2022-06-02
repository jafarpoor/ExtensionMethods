using System;


namespace Extension_Methods
{
    public class A : IMyInterface
    {
        public void MethodB()
        {
            { Console.WriteLine("A.MethodB()"); }
        }
    }

    public class B : IMyInterface
    {
        public void MethodB() { Console.WriteLine("B.MethodB()"); }
        public void MethodA(int i) { Console.WriteLine("B.MethodA(int i)"); }
    }

    public class C : IMyInterface
    {
        public void MethodB() { Console.WriteLine("C.MethodB()"); }
        public void MethodA(object obj)
        {
            Console.WriteLine("C.MethodA(object obj)");
        }
       }
    }
