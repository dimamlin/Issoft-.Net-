using System;

namespace task_1
{
    public class Matrix<T>
    {
        private T[] _Elements;
        private readonly int Size;

        public Matrix(int size, params T[] elements_)
        {
            Size = size >= 0 ? elements_.Length : throw new ArgumentNullException();

            if (elements_ == null)
            {
                size = 0;
            }
            else
            {
                _Elements = new T[elements_.Length];
                Size = elements_.Length;
                for (int i = 0; i < elements_.Length; i++)
                    _Elements[i] = elements_[i];
            }
        }

        public T this[int i, int j]
        {
            get
            {
                if ( i < 0 || j < 0 || i >= Size || j >= Size)
                {
                    throw new IndexOutOfRangeException();
                }
                    return  i == j ? _Elements[i] : default;
            }
            set 
            { 
                if (i < 0 || j < 0 || i >= Size || j >= Size)
                {
                    throw new IndexOutOfRangeException();
                }
                if (i == j)
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException();
                    }
                    OnElementChanged(new ElementChangedEventArgs<T>(_Elements[i], value, i));
                    _Elements[i] = value;
                }
            }
        }

        public override string ToString()
        {
            string elements_str = "";
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i == j)
                        elements_str += _Elements[i] + "\t";
                    else
                        elements_str += default(T) +"\t";
                }
                elements_str += "\n";
            }
            return elements_str;
        }

        public override bool Equals(object obj)
        {
            return obj is Matrix<T> p &&
                   Size == p.Size &&
                   ToString() == p.ToString();
        }

        public override int GetHashCode() => (Size + " " + this).GetHashCode();

        public event EventHandler<ElementChangedEventArgs<T>> ElementChanged;

        protected virtual void OnElementChanged(ElementChangedEventArgs<T> e)
        {
            ElementChanged?.Invoke(this, e);
        }
    }
}
