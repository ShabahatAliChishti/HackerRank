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
            //Insert Node at the Tail of a Linked List


        }
        static SinglyLinkedListNode  insertNodeAtTail(SinglyLinkedListNode head,int data,int position)
        {
            //initialize node on singly linked list with data 
            SinglyLinkedListNode node = new SinglyLinkedListNode(data);
          
            //advance the currentnode until we get to the node that is right before the position what we want to insert node at
            if(head==null)
            {
                return node;
            }
            else
            {
                //currentnode ki inialization head se hogi na
                var currentNode = head;
                //humaain next jb tk chalana hai jb tk akhiri node null ni miljati
                while(currentNode.next!=null)
                {
                    currentNode = currentNode.next;
                }
                //jb mil gayi node null tou us null ki jga humain apna data dalna hai means apni node
                currentNode.next = node;


            }
            //because head modified hojayega jb hum null ki jga value insert krdengy node ki apny
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
