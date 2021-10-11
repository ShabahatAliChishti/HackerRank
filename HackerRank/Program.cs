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
            //Print linked list

        }
        static void printLinkedList(SinglyLinkedListNode head)
        {
            //first thing we look at
            SinglyLinkedListNode node = head;
            //jb tk node null ni hojati jb tk chalao q ke usky bd humaray pass koi data ni hoga print honay ko
            while(node!=null)
            {
                Console.WriteLine(node.data);
                //shift our node
                node = node.next;
            }

            
            //because head modified hojayega jb hum null ki jga value insert krdengy node ki apny
         
        }
        public class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int data)
            {
                this.data = data;
                this.next = null;
            }


        }
        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }
            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);
                if (this.head == null)
                {
                    this.head = node;

                }
                else
                {
                    this.tail.next = node;
                }
            }
        }

    }
}
