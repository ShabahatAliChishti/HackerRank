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
            //print each element in linked list


        }
        static void  printLinkedList(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode node = head;
             while(node!=null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
           


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
