## Code Challenge 07

Developer: Andrew Hinojosa

K-th Value From The End Of A Linked List

Actual Time to complete: 1 Hours White Board / 2 Hours Coding

- White board partner: Mike Goseco
- Collaborator: Mike Goseco

### Challenge
For Code Challenge 0, write method for the linked list class which takes a numnber,k, as a parameter. Return the node's value that is k from the end of the linked. You have access to the Node class and all the properties on the linked list clas as well as the methods created in previous challenges.

### Approach & Efficiency
The approach taken was use the methods created from prevoius challenges. Then create a new method to instantiate an linked list and fill it with nodes. Then traverse the linked list with a loop and then return the node's value.
Big O Time = O(n) - The method must first traverse the entire list to measure the length, then loop again through it a fixed number of times for the length - k - 1, in order to find the correct node.
Big O Space = O(1) - Aside from the list, the method needs only one new variable to measure the length of the list.

### Solution
![White Board 07](https://github.com/drewsview34/data-structures-and-algorithms/blob/master/codeChallenges/linkedList07/whiteBoard07.jpg)
