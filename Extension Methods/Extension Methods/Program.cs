// See https://aka.ms/new-console-template for more information

using Extension_Methods;

A a = new A();
B b = new B();
C c = new C();


a.MethodA(1);           
a.MethodA("hello");
a.MethodB();


b.MethodA(1);         
b.MethodB();
b.MethodA("hello");

c.MethodA(1);        
c.MethodA("hello");     
c.MethodB();

Console.WriteLine();

Person person = new Person
{
    FristName = "faezeh",
    LastName = "jafarpour"
};
var FullName =person.GetFullName();
Console.WriteLine(FullName);
Console.WriteLine("Hello, World!");
Console.ReadKey();
