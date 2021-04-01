using System;

Matrix matrix_1 = new Matrix(1, 2, 3, 4, 5);
Matrix matrix_2 = new Matrix(1, 2, 3, 4, 5, 6);

Console.WriteLine("Матрица 1: \n" + matrix_1); // вывод исходных матриц
Console.WriteLine("Матрица 2: \n" + matrix_2);

Console.WriteLine("Размер матрицы 1: \n" + matrix_1.size); // размеры исходных матриц
Console.WriteLine("Размер матрицы 2: \n" + matrix_2.size);

Console.WriteLine("\nСумма элементов матрицы 1: \n" + matrix_1.Track()); // проверка метода Track
Console.WriteLine("Сумма элементов матрицы 2: \n" + matrix_2.Track());

Console.WriteLine("\nМатрицы равны: " + matrix_1.Equals(matrix_2)); // проверка переопределенных методов
Console.WriteLine("\nХеш-коды матриц: " + matrix_1.GetHashCode() + "  " + matrix_2.GetHashCode());

Console.WriteLine("\nСумма матриц 1 и 2: \n" + MatrixSum.Sum(matrix_1,matrix_2));






