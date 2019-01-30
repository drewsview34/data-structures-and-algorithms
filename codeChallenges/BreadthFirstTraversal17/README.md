## Code Challenge 17

Developer: Andrew Hinojosa

- White board partner: Jason Hiskey && Ryna Truong
- Contributor: Jason Hiskey && Ryna Truong && Mike Goseco

Actual Time to complete: 1 Hours White Board / ??? Hours Coding

# Breadth-first Traversal
This app demonstrates the breadth first method of binary tree traversal. Given an example tree, it will print out the node values of that tree, in order of each level, from the top down.

## Challenge
- Write a breadth first traversal method which takes a Binary Tree as its unique input. Without utilizing any of the built-in methods available to your language, traverse the input tree using a Breadth-first approach; print every visited node’s value.

## Approach & Efficiency
- Big O Space = O(w)
- Big O Time = O(n)
With this method, a queue is created to take in each node as it traverses each layer of the tree using a while loop. It begins by Enqueuing the root node, then Dequeuing and storing it as a Front node. That Front node value is printed and store to a list, then the Front node is checked for having left children then right children. If those children exist, they will be Enqueued in left-then-right order and the process will repeat while a node still exists in the queue.

## Solution
![whiteboard] (https://github.com/drewsview34/data-structures-and-algorithms/blob/master/codeChallenges/BreadthFirstTraversal17/Assets/BreadthFirstTraversal17.jpg)