class Stack(object):
    stack_List = [0]
    def __init__(self):
        self.stack_List = []

    def __init__(self, itemList):
        self.stack_List = itemList
        
    def __len__(self, listGiven):
        return len(listGiven)

    def __str__(self):
        return str(self.stack_List)

    def push(self, item):
        self.stack_List.append(item)

    def pop(self):
        return self.stack_List.pop()

class Queue(object):
    queue_List = [0]
    def __init__(self):
        self.queue_List = []

    def __init__(self, itemList):
        self.stack_List = itemList

    def __len__(self, listGiven):
        return len(listGiven)

    def __str__(self):
        return str(self.queue_List)

    def add(self, item):
        self.queue_List.append(item)

    def remove(self, index):
        del(self.queue_List[index])
        return self.queue_List

class Node(object):
    #data = ""
    #next = None
    def __init__(self, data, next = None):
        """Instantiates a Node with default next of None"""
        self.data = data
        self.next = next

class TwoWayNode(Node):

    def __init__(self, data, previous = None, next = None):
         Node.__init__(self, data, next)
         self.previous = previous 


# This is where the program implements the classes

def main():
    #StackClass()
    #QueueClass()
    print("\nStack With Nodes:")
    StackClassWithNodes()
    print("\nQueue With Nodes:")
    QueueClassWithNodes()
    
def StackClass():
    #Create the Stack object
    stack1 = Stack()

    #Push 5 numbers and display the effects.
    print("Push 5 times")
    for i in range(0,5,1):
        print("Current Stack List" + stack1.__str__())
        stack1.push(i)
        print("New Stack List" + stack1.__str__())
        print("Length: " + str(stack1.__len__(stack1.stack_List)))
        print()

    #Pop 5 numbers and display the effects.
    print("Pop 5 times")
    for i in range(0,5,1):
        print("Current Stack List" + stack1.__str__())
        stack1.pop()
        print("New Stack List" + stack1.__str__())
        print("Length: " + str(stack1.__len__(stack1.stack_List)))
        print()

def QueueClass():
    #Create the Queue object
    queue1 = Queue()

    #Add 5 numbers and display the effects.
    print("Add 5 times")
    for i in range(0,5,1):
        print("Current Queue List" + queue1.__str__())
        queue1.add(i)
        print("New Queue List" + queue1.__str__())
        print("Length: " + str(queue1.__len__(queue1.queue_List)))
        print()

    #Remove 5 numbers and display the effects.
    print("Remove 5 times")
    for i in range(0,5,1):
        print("Current Queue List" + queue1.__str__())
        queue1.remove(0)
        print("New Queue List" + queue1.__str__())
        print("Length: " + str(queue1.__len__(queue1.queue_List)))
        print()

def StackClassWithNodes():
    #Create the Stack object
    stackNode1 = None


    stackNodeList = [1,2,3]

    # Add five nodes to the beginning of the linked structure 
    for count in range(1, 6):
        if count == 1:
            stackNodeList = [1,2,3]
        if count == 2:
            stackNodeList = [2,3,4]
        if count == 3:
            stackNodeList = [3,4,5]
        if count == 4:
            stackNodeList = [4,5,6]
        if count == 5:
            stackNodeList = [5,6,7]
        stackNode1 = Node(Stack(stackNodeList), stackNode1)
        stackNode1.data.push(count)

    print("\nPrinting Data:")
    # Print the contents of the structure 
    while stackNode1 != None: 
        print(stackNode1.data)
        stackNode1 = stackNode1.next 

def QueueClassWithNodes():
    #Create the Stack object
    queueNode1 = None


    queueNodeList = [1,2,3]

    # Add five nodes to the beginning of the linked structure 
    for count in range(1, 6):
        if count == 1:
            queueNodeList = [1,2,3]
        if count == 2:
            queueNodeList = [2,3,4]
        if count == 3:
            queueNodeList = [3,4,5]
        if count == 4:
            queueNodeList = [4,5,6]
        if count == 5:
            queueNodeList = [5,6,7]
        queueNode1 = Node(Queue(queueNodeList), queueNode1)
        queueNode1.data.add(queueNodeList)

    print("\nPrinting Data:")
    # Print the contents of the structure 
    while queueNode1 != None: 
        print(queueNode1.data)
        queueNode1 = queueNode1.next 
main()
