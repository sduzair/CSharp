using csharpll;

MyLinkedList<int> list = new();

// list.AddLast(new MyLinkedListNode<Employee>(new("Uzair", new DateTime(1998, 4, 21))));
// list.AddLast(new MyLinkedListNode<Employee>(new("Alex", new DateTime(1997, 5, 28))));
// list.AddLast(new MyLinkedListNode<Employee>(new("Tom", new DateTime(2002, 4, 4))));
// list.AddLast(new MyLinkedListNode<Employee>(new("Ben", new DateTime(1995, 9, 1))));
list.AddLast(new MyLinkedListNode<int>(5));
list.AddLast(new MyLinkedListNode<int>(6));
list.AddLast(new MyLinkedListNode<int>(7));
list.AddLast(new MyLinkedListNode<int>(8));


// Console.WriteLine(new Employee("Uzair", new DateTime(1998, 4, 21)).ToString());

list.PrintMyLinkedList();
list.DeleteMiddleNode();
list.PrintMyLinkedList();