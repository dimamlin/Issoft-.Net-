public class Stack<T> : IStack<T>
{
    private T[] elements { get; } = new T[50];

    private int index { get; set; } = -1; // т.к. если индекс равен 0, значит в стеке уже есть 1 элемент под номером 0

    public void Push(T e) => elements[++index] = e;             
                                                                  // по сути я не удаляю элемент из массива, но реализованно все так, что невозможно снова 
    public T Pop() => index >= 0 ? elements[index--] : default;// получить доступ к удаленным элементам, не добавив их снова (считать, что удалил из стека)
                                                                  // если мы захотим удалить элемент из пустого стека, он вернет значение Т по умолчанию
    public bool IsEmpty() => index == -1;
}

