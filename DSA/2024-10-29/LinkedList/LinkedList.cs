using NodeNameSpace;

namespace LinkedListNameSpace;

public class LinkedList
{
    public Node? Head{get;set;}
    public Node? Tail{get;set;}
    public int Count{get;set;}

    public LinkedList(){
         Head = null;
         Tail = null;
         Count = 0;
    }

    public void AddFront(int value){
       Node tempNode = new Node(value);
       //case-01: when the linked list is empty
       if(Head == null){
           Head = tempNode;
           Tail = tempNode;
           Count++;
       //case-02: when adding an element in between first node and head
       }else{
           tempNode.Next = Head;
           Head = tempNode;
           Count++;
       }
    }

    public void AddLast(int value){
        Node tempNode = new Node(value);
        if(Tail == null){
            Head = tempNode;
            Tail = tempNode;
            Count++;
        }else{
            Tail.Next = tempNode;
            Tail = tempNode;
            Count++;
        }
    }

    public void Print(){
      Node? current = Head;

      while(current != null){
        Console.WriteLine($"{current.Data} - {current.Next}");
        current = current.Next;
      }
    }

    //todo : create inserat at & remove at
}
