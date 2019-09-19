using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LinkedList_Circular
{
    class Node
    { 

        private Button myVar;

    public Button NodeBT
    {
        get { return myVar; }
        set { myVar = value; }
    }

    public Node(string data, Node next)
        {
            this.data = data;
            this.next = next;
        }

        private string data;

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        private Node next;

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }
    }
    class LinkedListCircular
    {
        Node Last;
        //Node newNode;

        public void InsertNode(string item)
        {
            //newNode = new Node(item, null, null);
            if (Last == null)
            {
                Last = new Node(item, null);
                Last.Next = Last;
            }
            else
            {
                Node CurrentNode = Last.Next;
                Node PreviousNode = Last.Next;
                while (CurrentNode != Last && Convert.ToInt32(CurrentNode.Data) <= Convert.ToInt32(item))
                {
                    PreviousNode = CurrentNode;
                    CurrentNode = CurrentNode.Next;
                }
                if (!CurrentNode.Data.Equals(item))
                {
                    if (CurrentNode == Last && Convert.ToInt32(CurrentNode.Data) < Convert.ToInt32(item))
                    {
                        Last.Next = new Node(item, Last.Next);
                    }
                    else
                    {
                        PreviousNode.Next = new Node(item, CurrentNode);
                    }
                }
            }
        }

        public void DeleteNode(string item)
        {
            Node DelNode = new Node(item, null);
            DelNode.Data = item;
            if (Last == null)
            {
                Console.WriteLine("Nothing");
            }
            else
            {
                Node CurrentNode = Last.Next;
                Node PreviousNode = Last.Next;
                while (CurrentNode != Last && !CurrentNode.Data.Equals(item))
                {
                    PreviousNode = CurrentNode;
                    CurrentNode = CurrentNode.Next;
                }
                if (CurrentNode == Last && !CurrentNode.Data.Equals(item))
                {
                    Console.WriteLine("Nothing to del :" + item);
                }
                else
                {
                    PreviousNode.Next = CurrentNode.Next;
                }
            }
        }

        public void Traverse()
        {
            Node CurrentNode = Last.Next;
            while (CurrentNode != Last)
            {
                Console.WriteLine(CurrentNode.Data);
                CurrentNode = CurrentNode.Next;
            }
            Console.WriteLine(CurrentNode.Data);
        }
    }
}
