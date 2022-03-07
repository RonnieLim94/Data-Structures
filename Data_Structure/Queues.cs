using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    class Queues
    {
        Queues_Nodes head = null;
        Queues_Nodes tail = null;
        public void add(object data)
        {
            Queues_Nodes node = new Queues_Nodes(data);
            if (tail != null)
            {
                tail.next = node;
            }
            tail = node;
            if (head == null)
            {
                head = node;
            }
        }
        public object remove()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Queues are empty");
            }

            object data = head.data;
            head = head.next;
            if (head == null)
            {
                tail = head;
            }
            return data;
        }
        public bool isEmpty()
        {
            return head == null;
        }

    }
    class Queues_Nodes
    {
        public object data = null;
        public Queues_Nodes next = null;
        public Queues_Nodes(object data)
        {
            this.data = data;
        }
    }
}
