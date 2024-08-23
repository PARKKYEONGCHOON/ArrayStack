using System;

class CustomStack<T>
{
    private T[] stackArray;
    private int top;
    private int maxSize;

    
    public CustomStack(int size)
    {
        stackArray = new T[size];
        maxSize = size;
        top = -1;
    }

    
    public void Push(T item)
    {
        if (top >= maxSize - 1)
        {
            Console.WriteLine("Stack overflow");
        }
        else
        {
            stackArray[++top] = item;
        }
    }

    
    public T Pop()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack underflow");
            return default(T);
        }
        else
        {
            return stackArray[top--];
        }
    }

    // 스택의 맨 위 항목 확인
    public T Peek()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack is empty");
            return default(T);
        }
        else
        {
            return stackArray[top];
        }
    }

    
    public bool IsEmpty()
    {
        return top < 0;
    }

   
    public int Size()
    {
        return top + 1;
    }
}

class Program
{
    static void Main()
    {
        
        CustomStack<int> intStack = new CustomStack<int>(5);
        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);

        Console.WriteLine("Peek (int): " + intStack.Peek());  // 30
        Console.WriteLine("Pop (int): " + intStack.Pop());    // 30
        Console.WriteLine("Size (int): " + intStack.Size());  // 2

        
        CustomStack<string> stringStack = new CustomStack<string>(5);
        stringStack.Push("Hello");
        stringStack.Push("World");

        Console.WriteLine("Peek (string): " + stringStack.Peek());  // World
        Console.WriteLine("Pop (string): " + stringStack.Pop());    // World
        Console.WriteLine("Size (string): " + stringStack.Size());  // 1

        
        CustomStack<object> objectStack = new CustomStack<object>(5);
        objectStack.Push(1);
        objectStack.Push("Stack");
        objectStack.Push(3.14);

        Console.WriteLine("Peek (object): " + objectStack.Peek());  // 3.14
        Console.WriteLine("Pop (object): " + objectStack.Pop());    // 3.14
        Console.WriteLine("Size (object): " + objectStack.Size());  // 2
    }
}