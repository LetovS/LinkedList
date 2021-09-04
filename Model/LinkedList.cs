using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Codeblog.Model
{
    public class LinkedList<T> : IEnumerable
    {
        
        public Item<T> Head { get; private set; }
        
        public Item<T> Tail { get; private set; }
        
        public uint Count { get; set; }
        
        public LinkedList ()
        {
            Clear();
        }

        public LinkedList (T data)
        {
            
            SetHeadAndTail(data);
        }

        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
       
        public void Add (T data)
        {
            var item = new Item<T>(data);
            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        public void Appende (T data)
        {
            var item = new Item<T>(data);
            item.Next = Head;
            Head = item;
            Count++;
            
        }
        public void Insert(T target, T data)
        {

            
            var current = Head;
            if (Head != null)
            {
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else
            {
                Console.WriteLine("Искомого значения нет. Вставка не выполнена.");
            }


        }
        
        public void Delete (T data)
        {
            var item = new Item<T>(data);
            
           
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var current = Head.Next;
                var previous = Head;
                while (current != null )
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                    
                }                
            }
            else
            {
                Console.WriteLine("Linked list is empty.");
            }
        }

        public T Show(T data)
        {
            return data;
        }
        
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }

        }
        public override string ToString()
        {
            return $"Linked list  {Count}  elements";
        }
    }
}
