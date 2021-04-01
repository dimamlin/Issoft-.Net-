using System;

namespace task_1
{
    public class ElementChangedEventArgs<T> : EventArgs
    {
        public T Old { get; }
        public T New { get; }
        public int Index { get; }

        public ElementChangedEventArgs(T old, T @new, int index)
        {
            Old = old;
            New = @new;
            Index = index;
        }
    }
}
