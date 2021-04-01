using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SparseMatrix matrix = new SparseMatrix(10, 10);
            Console.WriteLine(matrix);
            matrix[5, 5] = 2;
            Console.WriteLine(matrix);
            //Console.WriteLine(matrix[5, 5]);
            foreach(var i in matrix)
            {
                Console.WriteLine(i);
            }
            var enumerator = matrix.GetNonzeroElements();
            foreach(var i in enumerator)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("____________________");
            foreach (var i in matrix)
            {
                Console.WriteLine(i);
            }
            var enumerator2 = matrix.GetNonzeroElements();
            foreach (var i in enumerator2)
            {
                Console.Write(i);
            }
            Console.WriteLine("____________________");
            Console.WriteLine(matrix.GetCount(2));
            matrix[10, 10] = 7;
            Console.WriteLine(matrix);
            Console.WriteLine("____________________");
            foreach (var i in matrix)
            {
                Console.Write(i);
            }
            var enumerator3 = matrix.GetNonzeroElements();
            foreach (var i in enumerator3)
            {
                Console.Write(i);
            }
            Console.WriteLine("____________________");
            matrix[9, 9] = 6;
            Console.WriteLine(matrix.GetCount(0));

            SparseMatrix matrix2 = new SparseMatrix(0, 0);
            Console.WriteLine(matrix2);
            Console.WriteLine("____________________");
            Console.WriteLine(matrix2);
            foreach (var i in matrix2)
            {
                Console.Write(i);
            }
            var enumerator4 = matrix2.GetNonzeroElements();
            foreach (var i in enumerator4)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("____________________");
        }
    }
}
