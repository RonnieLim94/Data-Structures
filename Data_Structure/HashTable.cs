using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    class HashTable
    {

        DoublyLinkedList[] HashTableLinkedListArray = null;

        public HashTable(int size)
        {
            HashTableLinkedListArray = new DoublyLinkedList[size];
        }

        public void insertion(string key, object data)
        {
            HashTableData hashTableData = new HashTableData(key, data);
            if (HashTableLinkedListArray[Hash(key)] == null)
            {
                DoublyLinkedList tempLinkedList = new DoublyLinkedList();
                tempLinkedList.addFirst(hashTableData);
                HashTableLinkedListArray[Hash(key)] = tempLinkedList;
            }
            else
            {
                HashTableLinkedListArray[Hash(key)].addFirst(hashTableData);
            }
        }

        public object search(string key)
        {
            var currentlist = HashTableLinkedListArray[Hash(key)].head;
            while (true)
            {
                if (currentlist.data.keys != key)
                {
                    currentlist = currentlist.next;
                }
                else
                {
                    break;
                }
            }
            return currentlist.data.value;
        }
       


        private int Hash(string key)
        {
            int ASCIISUM = 0;
            foreach (var i in key)
            {
                ASCIISUM += i;
            }
            return ASCIISUM % HashTableLinkedListArray.Length;
        }

    }

    class HashTableData
    {
        public object value;
        public string keys;
        public HashTableData(string keys, object value)
        {
            this.keys = keys;
            this.value = value;
        }
    }
   
}
