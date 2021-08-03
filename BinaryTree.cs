using System;

namespace Data_Structures
{
    class BTNode{
        public int value;
        public BTNode left;
        public BTNode right;

        public BTNode(int value)
        {
            this.left = null;
            this.value = value;
            this.right = null;
        }
    }

    class BinaryTree {
        public BTNode root;

        public BinaryTree()
        {
            root = null;
        }

        public BTNode AddNode(BTNode current, int value){
            if(current == null)
                return new BTNode(value);
            if(value > current.value)
                current.right = AddNode(current.right, value);
            if(value < current.value)
                current.left = AddNode(current.left, value);
            return current;
        }

        public void Print(BTNode current){
            if(current!=null){
                Print(current.left);
                Console.WriteLine(current.value);
                Print(current.right);
            }
        }
    }
}