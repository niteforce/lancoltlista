using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesztfeladat
{
    class LinkedList : IEnumerable
    {
        public Node Root { get; private set; }

        public LinkedList() { }
        public LinkedList(string[] values)
        {
            foreach (string value in values)
            {
                this.Add(value);
            }
        }

        public void Add(string value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                Node current = Root;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(value);
                current.Next.Previous = current;
            }

        }

        // http://stackoverflow.com/questions/12069205/implementing-c-sharp-ienumerablet-for-a-linkedlist-class

        public IEnumerator GetEnumerator()
        {
            var node = Root;
            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }             
    }
}
