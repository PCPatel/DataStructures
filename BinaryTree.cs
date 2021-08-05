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

        public void Delete(int value){
            DeleteNode(root, value);
        }

        private BTNode DeleteNode(BTNode current, int value){
            if(current == null){
                return null;
            }
            //search for the value
            if(value > current.value){
                current.right = DeleteNode(current.right, value);
            }
            else if(value < current.value){
                current.left = DeleteNode(current.left, value);
            }
            else {
                if(current.left == null && current.right == null){
                    return null;
                }
                else if(current.left == null || current.right == null){
                    return current.left ?? current.right;
                }
                else if(current.left != null && current.right != null){
                    var successor = current.right;
                    while(successor.left != null){
                        successor = successor.left;
                    }
                    current.value = successor.value;
                    current.right = DeleteNode(current.right, successor.value);
                }
            }
            return current;
        }

        private int i=0;
        public void Print(BTNode current){
            if(current!=null){
                i = i+4;
                Print(current.right);//! L
                Console.WriteLine(new String(' ',i) + current.value);//! N
                Print(current.left);//! R
                i = i-4;
            }
        }

        // LNR
        public void Print_LNR(BTNode current){
            Console.WriteLine("");
            Console.WriteLine("Print LNR");
            if(current!=null){
                Print(current.left);
                Console.Write(current.value + " - ");
                Print(current.right);
            }
        }

        // RNL
        public void Print_RNL(BTNode current){
            Console.WriteLine("");
            Console.WriteLine("Print RNL");
            if(current!=null){
                Print(current.right);
                Console.Write(current.value + " - ");
                Print(current.left);
            }
        }

        // NLR
        // LNR

    }
}