

public class Stack<T> {

    private T[] stackArray;
    private int top;
    private int maxSize;

   
    public Stack(int size) {
        stackArray = (T[]) new Object[size]; // 제네릭 배열 생성
        maxSize = size;
        top = -1;
    }

    
    public void push(T item) {
        if (top >= maxSize - 1) {
            System.out.println("Stack overflow");
        } else {
            stackArray[++top] = item;
        }
    }

    
    public T pop() {
        if (top < 0) {
            System.out.println("Stack underflow");
            return null;
        } else {
            return stackArray[top--];
        }
    }

    
    public T peek() {
        if (top < 0) {
            System.out.println("Stack is empty");
            return null;
        } else {
            return stackArray[top];
        }
    }

    
    public boolean isEmpty() {
        return top < 0;
    }

    // 스택의 크기 반환
    public int size() {
        return top + 1;
    }

    public static void main(String[] args) {
        
        Stack<Integer> intStack = new Stack<>(5);
        intStack.push(10);
        intStack.push(20);
        intStack.push(30);

        System.out.println("Peek (int): " + intStack.peek());
        System.out.println("Pop (int): " + intStack.pop()); 
        System.out.println("Size (int): " + intStack.size());  

        
        Stack<String> stringStack = new Stack<>(5);
        stringStack.push("Hello");
        stringStack.push("World");

        System.out.println("Peek (string): " + stringStack.peek()); 
        System.out.println("Pop (string): " + stringStack.pop());    
        System.out.println("Size (string): " + stringStack.size());
    }
}