#include <iostream>

template<typename T>
class Stack {
private:
    T* stackArray;
    int top;
    int maxSize;

public:
    
    Stack(int size) {
        stackArray = new T[size];
        maxSize = size;
        top = -1;
    }

    ~Stack() {
        delete[] stackArray;
    }

    
    void push(T item) {
        if (top >= maxSize - 1) {
            std::cout << "Stack overflow" << std::endl;
        } else {
            stackArray[++top] = item;
        }
    }

    
    T pop() {
        if (top < 0) {
            std::cout << "Stack underflow" << std::endl;
            return T();  
        } else {
            return stackArray[top--];
        }
    }

   
    T topElement() const {
        if (top < 0) {
            std::cout << "Stack is empty" << std::endl;
            return T();
        } else {
            return stackArray[top];
        }
    }

    
    bool isEmpty() const {
        return top < 0;
    }

   
    int size() const {
        return top + 1;
    }
};

int main() {
    
    Stack<int> intStack(5);
    intStack.push(10);
    intStack.push(20);
    intStack.push(30);

    std::cout << "Top (int): " << intStack.topElement() << std::endl;  
    std::cout << "Pop (int): " << intStack.pop() << std::endl;         
    std::cout << "Size (int): " << intStack.size() << std::endl;       
    
    Stack<std::string> stringStack(5);
    stringStack.push("Hello");
    stringStack.push("World");

    std::cout << "Top (string): " << stringStack.topElement() << std::endl;  
    std::cout << "Pop (string): " << stringStack.pop() << std::endl;         
    std::cout << "Size (string): " << stringStack.size() << std::endl;       

    return 0;
}