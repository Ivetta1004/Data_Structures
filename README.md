# Data_Structures
## Data structures for beginners
### All structures retain elements of type object.

***List***
This is a dynamic array, an array that can change its size.
There should be methods:
+ Add(object)
+ Insert(int, object)
+ Remove(object)
+ RemoveAt(int)
+ Clear()
+ bool Contains(object)
+ int IndexOf(object)
+ object [] ToArray()
+ Reverse().
There should also be an indexer property (read and write) and the Count property (read only).
Additionally, you can implement the Capacity property. 
Then, in addition to the default constructor, there must be a constructor that accepts Capacity. (Not necessary)

***Linked list***
Represents elements connected to each other through links to the next element.
The list contains the first and last elements.
Methods:
+ Add(object)
+ AddFirst(object)
+ Insert(Node, object)
+ Clear()
+ bool Contains(object)
+ object [] ToArray().
Properties Count, First, Last.

***Doubly linked list***
Represents elements connected to each other through links to the next and previous elements.
The list itself stores the first and last items.
Methods:
+ Add(object)
+ AddFirst(object)
+ Remove(object)
+ RemoveFirst()
+ RemoveLast()
+ bool Contains(object)
+ ToArray()
+ Clear().
Properties - Count, First, Last - all are read-only.

***Queue***
FIFO principle.
Methods:
+ Enqueue(object)
+ object Dequeue()
+ Clear()
+ bool Contains(object)
+ object Peek()
+ ToArray().
Property Count.

***Stack***
The principle of LIFO.
Methods:
+ Clear()
+ bool Contains(object)
+ object Peek()
+ ToArray()
+ Push(object)
+ object Pop().
Property Count.
