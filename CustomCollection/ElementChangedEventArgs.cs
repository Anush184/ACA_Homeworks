namespace CustomCollection;

public class ElementChangedEventArgs<T> : EventArgs
{
    public T Element { get; }

    public ElementChangedEventArgs(T element)
    {
        Element = element;
    }
}