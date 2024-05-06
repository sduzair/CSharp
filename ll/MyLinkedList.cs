namespace csharpll
{
    public class MyLinkedList<T>
        where T : notnull
    {
        public MyLinkedList()
        { }
        public MyLinkedListNode<T>? First { get; private set; } = null;
        public MyLinkedListNode<T>? Last { get; private set; } = null;
        public void AddLast(MyLinkedListNode<T> node)
        {
            if (Last is null)
            {
                First = node;
                Last = node;
                Count++;
                return;
            }
            Last.Next = node;
            Last = node;
            Count++;

        }
        public int Count { get; private set; }
        public void PrintMyLinkedList()
        {
            if (First == null) return;
            var item = First;
            System.Console.Write(item.Value.ToString() + "-> ");
            while (item.Next != null)
            {
                item = item.Next;
                System.Console.Write(item.Value.ToString() + "-> ");
            }
            System.Console.WriteLine();
        }
        public MyLinkedListNode<T>? GetMiddleNode()
        {
            // validate that the linked has a count of atleast 2
            if (Count < 2)
            {
                Console.WriteLine("The linked list must have atleast 2 nodes");
                return null;
            }

            // Iteration 0
            MyLinkedListNode<T> nodeRef1 = First!;
            MyLinkedListNode<T>? nodeRef2 = First!.Next;

            while (nodeRef2 != null && nodeRef2.Next != null)
            {
                // Iteration i
                nodeRef1 = nodeRef1.Next!;
                nodeRef2 = nodeRef2.Next?.Next;

            }
            MyLinkedListNode<T> middlNodeRef = nodeRef1;
            return middlNodeRef;
        }

        public void DeleteMiddleNode()
        {
            // validate that the linked has a count of atleast 2
            if (Count < 2)
            {
                Console.WriteLine("The linked list must have atleast 2 nodes");
                return;
            }
            var middleNode = GetMiddleNode();
            MyLinkedListNode<T> item = First!;
            while (item.Next != null)
            {
                if (item.Next == middleNode)
                {
                    item.Next = middleNode.Next;
                    middleNode.Next = null;
                    break;
                }
                item = item.Next;
            }
        }
    }
}