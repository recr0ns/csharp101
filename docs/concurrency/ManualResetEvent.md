# ManualResetEvent
ManualResetEvent is used for send signals between two or more threads.

Multiple threads can enter into a waiting/blocking state by calling the WaitOne method on ManualResetEvent object. 
When controlling thread calls the Set method all the waiting threads are unblocked and free to proceed.
