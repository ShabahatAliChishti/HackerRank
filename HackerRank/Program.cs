using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
           //insert a node at a specific position in a linked list
           //Q:given some data  and will be given position and so they expect us to make a node with the data and then insert into our linkedlist at the given desire position


        }
        static SinglyLinkedListNode  insertNodeAtPosition(SinglyLinkedListNode head,int data,int position)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(data);
            SinglyLinkedListNode currentNode = head;
            if(head==null)
            {
                return node;
            }
            for (int i = 0; i < position-1; i++)
            {
                currentNode = currentNode.next;
            }
            node.next = currentNode.next;
            currentNode.next = node;
            return head;

        }
        public class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

           public SinglyLinkedListNode(int data)
            {
                this.data = data;
            }

        }
       
    }
}
