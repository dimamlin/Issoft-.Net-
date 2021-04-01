public static class ReverseHelper
{
    public static IStack<T> Reverse<T>(this IStack<T> stack)
    {
        IStack<T> reverse_stack = new Stack<T>();
        int i = 0;
        T[] elements = new T[50];
        T counter;
        do
        {
            counter = stack.Pop();
            elements[i++] = counter;
        }
        while (!counter.Equals(default(T)));
        for (int j = 0; j < i - 1; j++)
        {
            reverse_stack.Push(elements[j]);
        }
        return reverse_stack;
    }
}
