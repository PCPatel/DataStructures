using System;
namespace Data_Structures
{
    public class LinkedList
    {
        public SglNode head;
        public SglNode tail;

        public LinkedList()
        {
            this.head = this.tail = null;
        }

        public void Add(int value){
            SglNode newNode = new SglNode(value);
            if(head==null) head = tail = newNode;
            else tail.next=newNode;
            tail = newNode;
        }

        public void AddToBack(int value){
            SglNode newNode = new SglNode(value);
            if(tail==null){
                head = tail = newNode;
            }
            else{
                tail.next = newNode;
                tail = newNode;
            }
        }

        public void AddToFront(int value){
            SglNode newNode = new SglNode(value);
            if(head==null) {
                head = tail = newNode;
            }
            else {
                newNode.next = head;
                head = newNode;
            }
        }

        public void Delete(int value){
            if(head.value.ToString() == value.ToString()){
                head = head.next;
                return;
            }
            for (SglNode current = head; current!=null;  current = current.next)
            {
                if(current.next.value.ToString() == value.ToString()){
                    if(current.next==tail){
                        tail=current;
                        current.next=null;
                    }
                    else
                        current.next = current.next.next;
                    break;
                }

            }
        }

        public override string ToString(){
            string listStr = "";
            for (SglNode current = head; current!=null;  current = current.next)
            {
                if(listStr.Length!=0) listStr+=" - ";
                listStr+=$"{current.value}";
            }
            return listStr;
        }
    }
}