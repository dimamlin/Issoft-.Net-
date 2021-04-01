using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class SparseMatrix : IEnumerable<int>
    {
        private readonly List<Element> elements = new(); // я почитал сравнения разных колекций и решил, что тут использовать List будет рациональнее всего 

        private int rows { get; }

        private int columns { get; }

        public SparseMatrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                throw new IndexOutOfRangeException();
            }

            this.rows = rows;
            this.columns = columns;
        }

        public int this[int row, int column]
        {
            get 
            {
                if(row <= 0 || row > rows || column <= 0 || column > columns)
                {
                    throw new IndexOutOfRangeException();
                }

                foreach (Element i in elements)
                {
                    if(i.row == row && i.column == column) 
                    {
                        return i.value;
                    }
                }

                return 0;
            }
            set
            {
                if (row <= 0 || row > rows || column <= 0 || column > columns)
                {
                    throw new IndexOutOfRangeException();
                }

                if (value != 0)
                {

                    bool isInList = false;
                    foreach (Element k in elements) // проверяем есть ли ненулевой элемент с такими же координатами в нашем списке
                    {
                        if (k.row == row && k.column == column)
                        {
                            k.value = value; // если есть, то просто меняем его значение
                            break;
                        }
                    }

                    if (!isInList) // если нет, то добавляем новый элемент
                    {
                        elements.Add(new Element(row, column, value));
                    }
                }
                else
                {
                    foreach (Element k in elements) // если мы вставляем вместо ненулевого элемента 0, то просто удалим старый элемент из нашего списка для экономии памяти
                    {
                        if (k.row == row && k.column == column)
                        {
                            elements.Remove(k);
                            break;
                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            string matrix_str = "";
            for(int i = 1; i <= rows; i++)
            {
                for(int j = 1; j <= columns; j++)
                {
                    bool isInList = false;
                    foreach (Element k in elements)
                    {
                        if (k.row == i && k.column == j)
                        {
                            matrix_str += k.value + " ";
                            isInList = true;
                        }
                    }
                    if (isInList)
                    {
                        continue;
                    }
                    else
                    {
                        matrix_str += "0 ";
                    }
                }
                matrix_str += "\n";
            }
            return matrix_str;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    bool isInList = false;
                    foreach (Element k in elements)
                    {
                        if (k.row == i && k.column == j)
                        {
                            isInList = true;
                            yield return k.value;
                        }
                    }
                    if (isInList)
                    {
                        continue;
                    }
                    else
                    {
                        yield return 0;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerable<(int, int, int)> GetNonzeroElements()
        {
            for (int i = 1; i <= columns; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    foreach (Element k in elements)
                    {
                        if (k.row == i  && k.column == j )
                        {
                            yield return (i, j, k.value);
                        }
                    }
                }
            }
        }

        public int GetCount(int x)
        {
            int counter = 0;

            if (x == 0)
            {
                counter = columns * rows - elements.Count;
            }
            else
            {
                for (int i = 1; i <= columns; i++)
                {
                    for (int j = 1; j <= rows; j++)
                    {
                        foreach (Element k in elements)
                        {
                            if (k.row == i && k.column == j && k.value == x)
                            {
                                counter++;
                            }
                        }
                    }
                }
            }

            return counter;
        }
        

        private class Element
        {
            public  int value { get; set; } 
            public int row { get; set; }
            public int column { get; set; }

            public Element(int row, int column, int value)
            {
                this.row = row;
                this.column = column;
                this.value = value;
            }
        }
    }
}
