public class EmptyListException : ApplicationException{
    public emptyListException(string name):base("List named " +name+" is empty")
    {
        
    }
}