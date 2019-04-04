using System;
public class DoublyLinkedList
{
    public DllNode Head;
    // Place your methods here.
    public DoublyLinkedList()
    {
        Head = null;
    }

    public void Add(int value)
    {
        DllNode newNode = new DllNode(value);
        if(Head == null)
        {
            Head = newNode;
        }
        else{
            DllNode runner = Head;
            while(runner.Next != null)
            {
                runner = runner.Next;
            }
            runner.Next = newNode;
            newNode.Prev=runner;

        }
    }

    public bool Remove(int value)
    {
        if(Head == null)
        {
            return false;
        }
        DllNode runner = Head;
        while(runner!=null)
        {
            if(runner.Value == value)
            {
                if(runner.Prev!=null)
                {
                    if(runner.Next !=null) //not the first node or last node
                    {
                        runner.Next.Prev = runner.Prev;
                        runner.Prev.Next = runner.Next;
                        return true;
                    }
                    else
                    {
                        runner.Prev.Next= null;// last node
                        return true;
                    }

                }
                else
                {
                    if (runner.Next != null) // the first node but not the last node
                    {
                        runner.Next.Prev = null;
                        Head = runner.Next;
                        return true;
                    }
                    else //this list hava only one node
                    {
                        Head = null;
                        return true;
                    }
                }
            }
            runner = runner.Next;
        }
        Console.WriteLine("didn't find a node contains given value");
        return false; //didn't find a node contains given value
    }
    
    public void Reverse()
    {
        if((Head == null)||(Head.Next==null))
        { return; }
        DllNode runner1 = Head;
        DllNode runner2 = Head.Next;
        DllNode runner3 = runner2;
        Head.Next = null;
        while(runner2!=null)
        {
            runner3 = runner2.Next;
            runner1.Prev = runner2;
            runner2.Next = runner1;
            runner1 = runner2;
            runner2 = runner3;
        }
        runner1.Prev = null;
        Head = runner1;
        

    }
    public void printIndo()
    {
        if(Head == null){
            Console.WriteLine("this list is empty");
            return;
        }
        DllNode runner = Head;
        while(runner!=null)
        {
            Console.WriteLine("this node's value is : " +runner.Value);
            runner = runner.Next;
        }
    }

}