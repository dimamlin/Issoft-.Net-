public class Matrix
{
    public int[] elements;

    public readonly int size;

    public Matrix(params int[] elements_)
    {
        if (elements_ == null)
        {
            size = 0;
        }
        else
        {
            elements = new int[elements_.Length];
            size = elements_.Length;
            for (int i = 0; i < elements_.Length; i++)
                elements[i] = elements_[i];
        }
    }

    public int this[int i, int j]
    {
        get
        {
            if (i != j || i < 0 || j < 0 || i >= size || j >= size)
            {
                return 0;
            }
            else
            {
                return elements[i];
            }
        }
        set { }
    }

    public int Track() {
        int sum = 0;
        foreach (int value in elements)
            sum += value;
        return sum;
    }

    public override string ToString()
    {
        string elements_str = "";
        //foreach (int value in elements)
        //    elements_str += value;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i == j)
                    elements_str += elements[i] + "\t";
                else
                    elements_str += "0\t";
            }
            elements_str += "\n";
        }
        return elements_str;
    }

    public override bool Equals(object obj)
    {
        return obj is Matrix p &&
               size == p.size &&
               ToString() == p.ToString();
    }

    public override int GetHashCode() => (size + " " + this).GetHashCode();
    
}