public class ListasEnlazadas {
    private node head;
    private node tail;
    private string name;

    public createlist (string listName){
        name=listName;
        head=tail=null;
    }

    public bool isListEmpty(){
        if(head==null){
            return true;
        }
        return false;
    }

    public void insertNode(int data){
        if(isListEmpty){
            head = tail = new node (data);
        }
        else
        {
            node n = new node (data);
            tail.next = n;
            tail=n;
        }
    }

    public void insertHeadNode(int data){
            node newHead = new node ();
        if(isListEmpty){
            newHead.newNode(data);
            head = tail = newHead;
        }
        else
        {
            newHead.setNext(head);
            newHead.setData(data);
            head = newHead;
        }
    }

    public void insertTailNode(int data){
            node newTail = new node();
            newTail.setData(data);
        if(isListEmpty){
            head = tail = newTail;
        }
        else
        {
            tail.setNext(newTail);
            tail=newTail;
        }
    }

    public int deleteHead (){
        if(isListEmpty){
            throw new emptyListException(name);
        }
        int deleteNode = head.getData;
        if (head == tail){
            head = tail= null;
        }
        else
        {
            head=head.next;
        }
        return deletedNode;
    }

    public void Print(){
        if(isListEmpty){
            
        }
    }

}