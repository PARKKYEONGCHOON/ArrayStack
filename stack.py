class Stack:
    def __init__(self):
        self.stack = []

    def push(self, item):
        
        self.stack.append(item)

    def pop(self):
       
        if not self.is_empty():
            return self.stack.pop()
        else:
            return "Stack is empty"

    def peek(self):
        """스택의 가장 위에 있는 항목을 반환"""
        if not self.is_empty():
            return self.stack[-1]
        else:
            return "Stack is empty"

    def is_empty(self):
       
        return len(self.stack) == 0
    
    def is_empty(self):
        
        if len(self.stack) == 0:
            return True
        else:
            return False
        
        

    def size(self):
        
        return len(self.stack)

    def __str__(self):
        
        return str(self.stack)

# 스택 사용 예제
my_stack = Stack()
my_stack.push(1)
my_stack.push(2)
my_stack.push(3)

print("Stack:", my_stack)  # [1, 2, 3]
print("Stack Size:", my_stack.size())  # 3

print("Pop:", my_stack.pop())  # 3
print("Stack Size:", my_stack.size())  # 2

print("Stack Peek:", my_stack.peek())  # 2
print("Stack isEmpty:", my_stack.is_empty())  # False