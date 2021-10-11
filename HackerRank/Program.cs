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
            //initialize node on singly linked list with data 
            SinglyLinkedListNode node = new SinglyLinkedListNode(data);
            //to look at every single node that's called current node and it starting with head
            SinglyLinkedListNode currentNode = head;
            //advance the currentnode until we get to the node that is right before the position what we want to insert node at
            if(head==null)
            {
                return node;
            }
            for(int i=0;i<position-1;i++)
            {
                //iterating towards next node and set that node into currentnode
                currentNode = currentNode.next;
            }
            //for change references we have to remember we have to do that at specific order so before we can remove the reference from current node we have to say node next is equal to current node and therefore we hold on that reference and we make sure it doesn't get chopped when we do the next line which is saying that the current node next is equal to node
            node.next = currentNode.next;
            currentNode.next = head;
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
