using System;
namespace Data_Structures
{
    public class SglNode
    {
        public int value;
        public SglNode next;

        public SglNode(int value)
        {
            this.value = value;
            this.next = null;
        }
    }
}