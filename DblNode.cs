using System;
namespace Data_Structures
{
    public class DblNode
    {
        public int value;
        public DblNode prev;
        public DblNode next;

        public DblNode(int value)
        {
            this.prev = null;
            this.value = value;
            this.next = null;
        }
    }
}