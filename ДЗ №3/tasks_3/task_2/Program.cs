using System;

IStack<int> a = new Stack<int>();

Console.WriteLine(a.IsEmpty());
Console.WriteLine(a.Pop());
Console.WriteLine(a.IsEmpty() + "\n");

a.Push(1);
Console.WriteLine(a.IsEmpty());
Console.WriteLine(a.Pop());
Console.WriteLine(a.IsEmpty() + "\n");

Console.WriteLine(a.Pop());
Console.WriteLine(a.Pop());
Console.WriteLine(a.Pop());
Console.WriteLine(a.IsEmpty() + "\n");

a.Push(1);
a.Push(2);
a.Push(3);
a.Push(4);
a.Push(5);
Console.WriteLine(a.IsEmpty());
Console.WriteLine(a.Pop());
Console.WriteLine(a.Pop());
Console.WriteLine(a.Pop());
Console.WriteLine(a.Pop());
Console.WriteLine(a.Pop());
Console.WriteLine(a.IsEmpty() + "\n");

a.Push(1);
a.Push(2);
a.Push(3);
a.Push(4);
a.Push(5);
a = a.Reverse<int>();

Console.WriteLine(a.IsEmpty());
Console.WriteLine(a.Pop());
Console.WriteLine(a.Pop());
Console.WriteLine(a.Pop());
Console.WriteLine(a.Pop());
Console.WriteLine(a.Pop());
Console.WriteLine(a.IsEmpty());

