public static class MatrixSum
{
    public static Matrix Sum(this Matrix m, Matrix p)
    {
        if(m.size == p.size)
        {
            int[] arr = new int[m.size];
            for(int i = 0; i < m.size; i++)
                arr[i] = m.elements[i] + p.elements[i];
            return new Matrix(arr);
        }
        else
        {
            if(m.size > p.size)
            {
                int[] arr = new int[m.size];
                for(int i = 0; i < p.size; i++)
                    arr[i] = m.elements[i] + p.elements[i];
                for (int i = p.size; i < m.size; i++)
                    arr[i] = m.elements[i];
                return new Matrix(arr);
            }
            else
            {
                int[] arr = new int[p.size];
                for (int i = 0; i < m.size; i++)
                    arr[i] = m.elements[i] + p.elements[i];
                for (int i = m.size; i < p.size; i++)
                    arr[i] = p.elements[i];
                return new Matrix(arr);
            }
        }
    }
}
