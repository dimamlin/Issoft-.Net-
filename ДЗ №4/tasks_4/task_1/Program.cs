using System;
using task_1;

//Matrix<int>[] arr = new Matrix<int>[4];

//task_1.Matrix<Matrix<int>[]> a = new(3, arr);

////a[1,1] = 'd';

//a.ElementChanged += (_, e) => Console.WriteLine($"Old = {e.Old}, New = {e.New}, Index = {e.Index}" );

//a[1, 1] = null;

char[] arr = new char[5] { 'a', 'b', 'c', 'd', 'e' };

Matrix<char> a = new Matrix<char>(5, arr);

a.ElementChanged += (_, e) => Console.WriteLine($"Old = {e.Old}, New = {e.New}, Index = {e.Index} : {e.Index}");


Console.WriteLine(a[1, 2]);

Console.WriteLine(default(char));


a[2, 2] = 'd';


