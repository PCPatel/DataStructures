using System;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            // //! Linked List
            // LinkedList list = new LinkedList();
            // list.Add(1);
            // list.Add(2);
            // list.Add(3);
            // //list.Delete(2);
            // Console.WriteLine(list.ToString());
            // list.PrintBackword(list.head);

            // //! Doubly Linked List
            // DoublyLinkedList list = new DoublyLinkedList();
            // list.AddToBack(1);
            // list.AddToBack(2);
            // list.AddToBack(3);
            // list.AddToBack(4);
            // list.AddToBack(5);
            // list.PrintForward();

            // //! Sentinel List
            // var list = new SentinelList();
            // list.AddToBack(1, 2, 3);
            // list.PrintForward();
            // list.InsertBefore(1,4);
            // list.PrintForward();
            // list.InsertAfter(1,5);
            // list.PrintForward();

            //! Binary Tree
            var bt = new BinaryTree();
            bt.root = bt.AddNode(bt.root, 5);
            bt.root = bt.AddNode(bt.root, 1);
            bt.root = bt.AddNode(bt.root, 7);
            //bt.root = bt.AddNode(bt.root, -5);
            bt.root = bt.AddNode(bt.root, 9);
            bt.root = bt.AddNode(bt.root, 6);
            bt.Print(bt.root);
            //bt.Print_LNR(bt.root);
            //bt.Print_RNL(bt.root);
            Console.WriteLine("After Delete");            
            // bt.Delete(1);
            // bt.Delete(6);
            // bt.Delete(9);
            bt.Delete(7);
            bt.Print(bt.root);

            // //! Recursion
            // var rec = new Recursion();
            // Console.WriteLine(rec.Factorial(10));
            // Console.WriteLine(rec.Factorial_NonRecursion(10));
        }
    }
}
