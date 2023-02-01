namespace csharpll
{
    public class MyLinkedListNode<T>
        where T : notnull
    {
        public T Value { get; set; }
        public MyLinkedListNode<T>? Next { get; set; }
        public MyLinkedListNode(T value)
        {
            Value = value;
        }
    }
}