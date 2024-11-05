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
       if(Head == null || Tail == null || Count == 0 ){
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
        Console.WriteLine($"{current.Data}");
        current = current.Next;
      }
    }
    
    public void InsertAt(int value, int index){
        Node tempNode = new Node(value);
        if(index < 0 || index > Count){
            Console.WriteLine("Invalid index");
            return;
        }
        
        //case-01: inserting as first element
        if(index == 0){
            AddFront(value);
            
        }

        //case-02: inserting as last element   
        else if(index == Count){
            AddLast(value);
            
        }

        //case-03: inserting at between the start and end
        else {
            Node prev = Head;

            for(int i = 0 ; i < index-1; i++){
                prev = prev.Next;
            }

            //Now prev is the element before the provided index
            tempNode.Next = prev.Next;
            prev.Next = tempNode;

            //int i = 1;
            // while(prev != null && i < index-1){
            //     prev = prev.Next;
            // }
        }
    }

    public void DeleteAt(int index){
        if(index < 0 || index > Count - 1){
            Console.WriteLine("Invalid Index");
            return;
        }
        
        if(index == 0){
            Head = Head.Next;
            if(Count == 1){
                Tail = null;
            }
            
        }else {
            Node prev = Head;

            for(int i = 0 ; i < index -1 ; i++){
                prev = prev.Next;
            }

            prev.Next = (prev.Next).Next;

            if(index == Count - 1){
                Tail = prev;
            }
            Count--;
        }


    }

    public Node Search(int value){
        Node current = Head;

        while(current != null){
            if(current.Data == value){
                Node copy = new Node(current.Data);
                return copy;
            }else{
                current = current.Next;
            }
        }
        return null;
    }
}
