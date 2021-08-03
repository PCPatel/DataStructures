using System;
namespace Data_Structures
{
    public class DoublyLinkedList
    {
        public DblNode head;
        public DblNode tail;

        public DoublyLinkedList()
        {
            this.head = this.tail = null;
        }

        public void AddToBack(int value){
            DblNode newNode = new DblNode(value);
            if(head==null) head = tail = newNode;
            else {
                tail.next=newNode;
                newNode.prev = tail;
            }
            tail = newNode;
        }

        public void AddToFront(int value){
            DblNode newNode = new DblNode(value);
            if(head==null) {
                head = tail = newNode;
            }
            else {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
        }

        public void InsertBefore(int beforeValue, int valueToAdd){
            for (DblNode current = head; current != null;  current = current.next)
            {
                if(beforeValue==current.value){
                    if(current==tail) {
                        AddToFront(valueToAdd);
                        break;
                    }

                    DblNode newNode = new DblNode(valueToAdd);
                    newNode.next = current;
                    newNode.prev = current.prev;
                    //current.next.prev = newNode;
                    //current.next = newNode;
                    newNode.prev.next = newNode.next.prev = newNode;
                    break;
                }
            }
        }
        
        public void InsertAfter(int afterValue, int valueToAdd){
            for (DblNode current = head; current != null;  current = current.next)
            {
                if(afterValue==current.value){
                    if(current==tail) {
                        AddToBack(valueToAdd);
                        break;
                    }

                    DblNode newNode = new DblNode(valueToAdd);
                    newNode.prev = current;
                    newNode.next = current.next;
                    //current.next.prev = newNode;
                    //current.next = newNode;
                    newNode.prev.next = newNode.next.prev = newNode;
                    break;
                }
            }
        }

        public void Delete(int value){
            for (DblNode current = head; current!=null;  current = current.next)
            {
                if(value==current.value){

                    if(head==tail){
                        head=tail=null;
                        break;
                    }
                    
                    if(current==head){
                        current.next.prev = null;
                        head = current.next;
                        break;
                    }

                    if(current==tail){
                        current.prev.next = null;
                        tail = current.prev;
                        break;
                    }

                    current.prev.next = current.next;
                    current.next.prev = current.prev;
                    break;
                }
            }   
        }

        public void DeleteAlternate(int StartValue, int StopValue, int SkipCount){
            bool startNodeFound = false;
            bool stopNodeFound = false;
            int nodeCounter = 0;

            for (var current = this.head; current!=null; current = current.next)
            {
                if(current.value == StartValue) startNodeFound = true;
                if(current.value == StopValue) stopNodeFound = true;
                if(!startNodeFound) continue;

                if(current.value == StartValue || nodeCounter==SkipCount) {
                    nodeCounter = 0;
                    Delete(current.value);
                }
                else
                    nodeCounter+=1;

                if(stopNodeFound) break;
            }
        }

        public void Sort_Interchanging_Values(){
            if(head == tail) return;
            for(DblNode current = head, reverse = tail; current.next != null && reverse.prev!=null; current = current.next, reverse = reverse.prev){
                var temp = current.value;
                current.value = reverse.value;
                reverse.value = temp;
            }
        }

        public void Sort_Replace_Pointers(){

            if(head==null || head==tail) return;
            DblNode temp;
            for (var current = head; current.next != null; current = current.next)
            {
                temp = current;
                current.next = current.prev;
                current.prev = temp.next;
                if(current==head) current.next=null;
                if(current==tail) current.prev=null;
            }
            temp = head;
            head = tail;
            tail= temp;
        }

        public void PrintForward(){
            //string listStr = "";
            for (DblNode current = head; current!=null;  current = current.next)
            {
                // if(listStr.Length!=0) listStr+=" - ";
                // listStr+=$"{current.value}";
                Console.WriteLine(current.value);
            }
           // return listStr;
        }

        public string PrintBackward(){
            string listStr = "";
            for (DblNode current = tail; current!=null;  current = current.prev)
            {
                if(listStr.Length!=0) listStr+=" - ";
                listStr+=$"{current.value}";
            }
            return listStr;
        }
    }
}