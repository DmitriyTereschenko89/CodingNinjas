# Bounded Blocking Queue

## Problem statement
Implement a bounded blocking queue that has the following functions:

BoundedBlockingQueue( int capacity ): Creates a queue of the given capacity.

Void Enqueue(int val): Adds an element to the end of the queue. If the queue is full, enqueue request gets blocked until the queue has no empty space i.e the element is stored at some other space and enqueued in the list when there is space in the queue.  

Int Dequeue(): Returns the element at the front of the queue and blocks the dequeue request if there are no items in the queue until the queue has an element enqueued.

Int Size(): Returns the size of the queue.

You will be given ‘Q’ queries. You need to implement a bounded blocking queue according to those queries. Each query will belong to one of these two types:

0 ‘C’: Creates a queue of a capacity ‘C’.

1 ‘X’: Enqueue element ‘X’  into the end of the queue. 

2: Dequeue the element at the front of the queue. 
Returns -1 if the queue is empty, otherwise, returns the dequeued element.

3: Returns the size of the queue.

Constraints :
1 <= T <= 10
1 <= Q <= 10^5 
0 <= P <= 3
1 <= X <= 10^5

Where 'P’, denotes the type of query.‘X’ is the element to be enqueued in case the query type is ‘1’.

Time Limit : 1sec
## Sample Input 1 :
2
7
0 5
1 3
1 9
2 
3
2
3
4
0 2
2
1 7
3
## Sample Output 1 :
3 1 9 0
-1 7 0
## Explanation Of Sample Input 1 :
## Test Case 1:  For this input, we have number of queries, Q = 7.
Operations performed on the queue are as follows:
0 5 -> A queue of capacity ‘5’ is initialized.
1 3-> Enqueue 1 to back of the queue. q= [3]
1 9 -> Enqueue 9 to back of queue. q= [3,9]
2 -> Dequeue front element and return 3 . q= [ 9 ].
3 -> Return size of queue i.e 1.
2-> Dequeue front element. q= [ ].
3 -> Return the size of the queue. I.e 0.

Test Case 2: For this input, we have the number of queries, Q = 4.
0 2 -> A queue of capacity ‘2’ is initialized.
2 -> We have to dequeue an element but as the queue is empty this request will go to a blocked state and return -1.
1 7 -> Enqueue 7 to the queue. Now the blocked request of dequeue will be unblocked So dequeue front element i.e ‘7’ and return it. 
3 -> Return the size of the queue i.e ‘0’.
## Sample Input 2 :
2
2
0 8
2
3
0 11
1 4
1 21
## Sample Output 2 :
-1    