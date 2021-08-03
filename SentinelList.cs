using System;

namespace Data_Structures
{
    public class SentinelList{
        public DblNode head;
        public DblNode tail;

        public SentinelList()
        {
            this.head = new DblNode(0);
            this.tail = new DblNode(0);
            this.head.next = this.tail;
            this.tail.prev = this.head;
        }

        private void CommonAdd(int value, DblNode prevPointer){
            var newNode = new DblNode(value);
            newNode.prev = prevPointer;
            newNode.next = prevPointer.next;
            newNode.prev.next = newNode.next.prev = newNode;
        }

        public void AddToBack(params int[] values){
            foreach (var value in values)
            {   
                CommonAdd(value, tail.prev);
                // Node newNode = new Node(value);
                // newNode.next = tail;
                // newNode.prev = tail.prev;
                // newNode.prev.next = newNode;
                // newNode.next.prev =newNode;
            }
        } 

        public void AddToFront(params int[] values){
            foreach (var value in values)
            {
                CommonAdd(value, head);
                // Node newNode = new Node(value);
                // newNode.prev = head;
                // newNode.next = head.next;
                // newNode.prev.next = newNode;
                // newNode.next.prev =newNode;
            }
        }

        public void InsertBefore(int valueToSearch, params int[] values){
            for(var current = head.next; current != tail; current = current.next){
                if(current.value == valueToSearch){
                    foreach (var value in values)
                    {
                        CommonAdd(value, current.prev);
                    }
                    
                    // var newNode = new Node(valueToInsert);
                    // newNode.next = current;
                    // newNode.prev = current.prev;
                    // newNode.prev.next = newNode;
                    // newNode.next.prev = newNode;
                    return;
                }
            }
        }

        public void InsertAfter(int valueToSearch, params int[] values){
            for(var current = head.next; current != tail; current = current.next){
                if(current.value == valueToSearch){
                    foreach (var value in values)
                    {   
                        CommonAdd(value, current);
                    }
                    // var newNode = new Node(valueToInsert);
                    // newNode.prev = current;
                    // newNode.next = current.next;
                    // newNode.prev.next = newNode;
                    // newNode.next.prev = newNode;
                    return;
                }
            }
        }

        public void Delete(int value){
            for(var current = head.next; current != tail; current = current.next){
                if(current.value == value){
                    current.prev.next = current.next;
                    current.next.prev = current.prev;
                    return;
                }
            }
        }

        public void Reverse_Pointers(){
            for(var current = head.next; current != tail; current = current.next){
                
            }
        }

        public void PrintForward(){
            var listStr = "";
           for(var current = head.next; current != tail; current = current.next){
                if(listStr.Length == 0) listStr = current.value.ToString();
                else listStr+=$" - {current.value}";
           }
           Console.WriteLine($"Forward: {listStr}");
        }

        public void PrintBackward(){
            var listStr = "";
           for(var current = tail.prev; current != head; current = current.prev){
                if(listStr.Length == 0) listStr = current.value.ToString();
                else listStr+=$" - {current.value}";
           }
           Console.WriteLine($"Backward: {listStr}");
        }
    }
}
