using csharpqueue;

MyQueue<int> queue = new();

for (int i = 0; i < 0; i++)
{
    queue.Enqueue(i + 1);
}

queue.PrintQueue();
queue.Dequeue();
queue.PrintQueue();