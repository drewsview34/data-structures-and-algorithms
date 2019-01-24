## Code Challenge 12

Developer: Andrew Hinojosa

- White board partner: Ahmad Ali
- Contributor: ???
- Collaborator: ???

Actual Time to complete: 1 Hours White Board / 3 Hours Coding

### Implement A Queue Using Two Stacks
This challenge focuses on the First In First Out (FIFO) concept of Queues.

### Challenge
For Code Challenge 12, Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.
Implement the following methods:
- enqueue(animal): adds animal to the shelter. animal can be either a dog or a cat object.
- dequeue(pref): returns either a dog or a cat. If pref is not "dog" or "cat" then return null.

### Approach & Efficiency
The approach is to create an enqueue and dequeue method. Use the Enqueue method to fill the nodes with cat, dog, and any. Then Dequeue the nodes for the users choice, lets say cat and dequeue until we return cat.
 - Enqueue for time and space, it would be O(1) no matter how much we utlize the pop and pop it will always take the same amount of time to complete.
 - Dequeue for time, it would be O(n) becuase we don't know how big the list of dogs and cats are in the list. For space, it would be 0(1) no matter how much we utlize the pop and pop it will always take the same amount of time to complete.


### Solution
![White Board ](https://github.com/drewsview34/data-structures-and-algorithms/blob/master/codeChallenges/FIFOQueue12/Assets/FIFOQueue12.jpg)
