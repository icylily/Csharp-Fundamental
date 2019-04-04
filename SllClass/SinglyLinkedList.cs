using System;
public class SinglyLinkedList
{
    public SllNode Head;
    public SinglyLinkedList()
    {
        Head = null;
    }
    // SLL methods go here. As a starter, we will show you how to add a node to the list.
    public void Add(int value)
    {
        SllNode newNode = new SllNode(value);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            SllNode runner = Head;
            while (runner.Next != null)
            {
                runner = runner.Next;
            }
            runner.Next = newNode;
        }
    }
    public void Remove()
    {
        if (Head == null)
        {
            return ;
        }
        else
        {
            SllNode runner1 = Head;
            SllNode runner = Head.Next;
            if(runner == null){
                Head = null;
                return;
            }
            else{
                while(runner.Next!=null)
                {
                    runner1=runner;
                    runner = runner.Next;
                }
                runner1.Next = null;
                return;
            }
        }
    }
    public void PrintValues()
    {
        if(Head == null)
        {
            Console.WriteLine("This list is empty.");
            return;
        }
        else{
            SllNode runner = Head;
            while( runner != null)
            {
                Console.WriteLine("Value is:"+runner.Value);
                runner = runner.Next;
            }
            return;
        }
    }

    public SllNode Find(int value)
    {
        if(Head == null)
        {
            Console.WriteLine("this list is empty");
            return null;
        }
        else
        {
            SllNode runner = Head;
            while(runner != null)
            {
                if(runner.Value == value)
                {
                    Console.WriteLine("find this item");
                    return runner;
                } 
                runner= runner.Next;
            }
            Console.WriteLine("can not find this item");
            return null;
        }
    }

    public bool RemoveAt(int n)
    {
        if((Head==null)||(n<0))
        {
            return false;
        }
        else if(n == 0)
        {
            Head = Head.Next;
            return true;
        }
        else 
        {
            SllNode runner1 = Head;
            SllNode runner2 = Head.Next;
            while(n-1>0)
            {
                if(runner2==null)
                {
                    return false;
                }
                else
                {
                    runner1 = runner2;
                    runner2 = runner2.Next;
                }
                n--;
            }
            runner1.Next=runner2.Next;
            return true;
        }

    }
}