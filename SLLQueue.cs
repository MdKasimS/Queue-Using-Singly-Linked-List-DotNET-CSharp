namespace DSA
{
    public class SLLQueue
    {
        private static int count = 0;
        private SLLNode? temp;
        private SLLNode? head;
        public SLLNode? Temp { get => temp; set => temp = value; }
        public SLLNode? Head { get => head; set => head = value; }
        public static int Count { get => count; set => count = value; }
        public SLLQueue()
        {
            Head = null;
            Temp = null;
        }
        public void Enqueue(int data)
        {
            if (Head == null)
            {
                Head = new SLLNode(data);
                Temp = Head;
                ++Count;
            }
            else
            {
                Temp.Next = new SLLNode(data);
                Temp = Temp.Next;
                ++Count;
            }
        }
        public void DisplayQueue()
        {
            if (Head != null)
            {
                SLLNode? iterator = this.Head;
                for (int i = 0; i < Count; ++i)
                {
                    Console.Write($"{iterator.Data}-");
                    iterator = iterator.Next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Queue Status : {isEmpty()}");
            }
        }

        public void Dequeue()
        {
            if (Head != null)
            {
                Head = Head.Next;
                --Count;
            }
            else
            {
                Console.WriteLine("Out Of Bound");
            }
        }

        public string Peek()
        {
            if (Head != null)
                return Head.Data.ToString();

            return isEmpty();
        }

        public string isEmpty()
        {
            if (Count == 0)
                return "Empty";

            return "Not Empty";
        }
    }
}