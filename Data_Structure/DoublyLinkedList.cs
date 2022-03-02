using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    class DoublyLinkedList
    {
        public Node head = null;
        public Node tail = null;
        /// <summary>
        /// Add a node to the last position of the linked list
        /// </summary>
        /// <param name="data"></param>
        public void addLast(object data)
        {
            if (head == null)
            {
                head = new Node(data, null, null);
            }
            else if (tail == null)
            {
                tail = new Node(data, null, head);
                head.next = tail;
            }
            else
            {
                Node tempNode = tail;
                tail = new Node(data, null, tempNode);
                tempNode.next = tail;
                tempNode.prev.next = tempNode;
            }
        }
        /// <summary>
        /// Add a node to the first position of the linked list
        /// </summary>
        /// <param name="data"></param>
        public void addFirst(object data)
        {
            if (head == null)
            {
                head = new Node(data, null, null);
            }
            else
            {
                Node currentNode = head;
                while (currentNode != null)
                {
                    currentNode = currentNode.next;
                }
                Node newNode = new Node(data, null, currentNode);
                currentNode.next = newNode;
            }
        }
        /// <summary>
        /// Print out all of the data in the linked list
        /// </summary>
        public void printAllNodes()
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
        }
    }
    class Node
    {
        public object data = null;
        public Node next = null;
        public Node prev = null;
        public Node(object data, Node next, Node prev)
        {
            this.data = data;
            this.next = next;
            this.prev = prev;
        }
    }
}
