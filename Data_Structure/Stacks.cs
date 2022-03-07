using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    class Stacks
    {
        public Stacks_Node head = null;
        public void push(object data)
        {
            Stacks_Node node = new Stacks_Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }
        public object pop()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Stacks are empty");
            }
            object data = head.data;
            head = head.next;
            return data;
        }
        public bool isEmpty()
        {
            return head == null;
        }
        
    }
    class Stacks_Node
    {
        public Stacks_Node next = null;
        public object data = null;
        public Stacks_Node(object data)
        {
            this.data = data;
        }

    }
}
