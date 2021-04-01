public interface IStack<T>
{
    void Push(T e);

    T Pop();

    bool IsEmpty();
}
