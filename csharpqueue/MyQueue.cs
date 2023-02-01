namespace csharpqueue
{
    public class MyQueue<T>
    // where T : notnull
    {
        private readonly LinkedList<T> _items;
        public int Count => _items.Count;
        public T Peek => _items.First!.Value;
        // trypeek 
        public bool TryPeek(out T? value)
        {
            if (_items.Count == 0)
            {
                value = default;
                return false;
            }
            value = _items.First!.Value;
            return true;
        }


        public MyQueue()
        {
            _items = new LinkedList<T>();
        }
        public void Enqueue(T value)
        {
            _items.AddLast(value);
        }

        public T? Dequeue()
        {
            if (_items.First == null) return default;
            LinkedListNode<T> first = _items.First;
            _items.RemoveFirst();
            return first.Value;
        }

        public void PrintQueue()
        {
            System.Console.WriteLine("Printing queue...");
            foreach (var item in _items)
            {
                Console.Write(item + " -> ");
            }
            System.Console.WriteLine();
        }
    }
}