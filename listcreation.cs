using System.Collections.Generic;


namespace ListCreation
{
    public class ListNode<T>
    {
        T value;
        ListNode<T> next;
    }
    public class MyList<T> : IList<T>
    {
        ListNode<T> head;
        ListNode<T> tail;
        public MyList<T>()
        {
            this.head = null;
            this.tail = null;
        }


        public int Count {get{
            if (this.head == null)
            {
                return 0;
            }
            else 
            {
                int counter = 1;
                for (ListNode<T> node = this.head; node.next != null; node = node.next, counter++);
                return counter;
                // do { //define node here, redefine it as well , counter++ while(node.next!=null)}
            }
        }}

        public bool IsReadOnly {get{
            return true;
        }}

        public T this[int index] {get{
            if (index < 0 || index > this.Count - 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            else 
            {
                int counter = 0;
                for (ListNode<T> node = this.head; node.next != null; node = node.next)
                {
                    if (index = counter)
                    {
                        return node.value;
                    }
                    counter++;
                 }
                
                
            }
            
            
        }}
        

        public void Add(T value)
        {
            
        }

    }
}
