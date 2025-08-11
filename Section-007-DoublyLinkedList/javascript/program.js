import DoublyLinkedList from "./DoublyLinkedList.js";

console.log("Doubly Linked List Example");
const myDoublyLinkedList = new DoublyLinkedList(7);
myDoublyLinkedList.printList();

console.log("Adding nodes to the doubly linked list via push:");
myDoublyLinkedList.push(10);
myDoublyLinkedList.push(15);
myDoublyLinkedList.printList();
myDoublyLinkedList.printListBackwards();

console.log("Popping the last 3 nodes from the doubly linked list:");
myDoublyLinkedList.pop();
myDoublyLinkedList.pop();
myDoublyLinkedList.pop();
myDoublyLinkedList.printList();
myDoublyLinkedList.printListBackwards();

console.log("Unshifting nodes to the doubly linked list:");
myDoublyLinkedList.unshift(5);
myDoublyLinkedList.unshift(2);
myDoublyLinkedList.printList();
myDoublyLinkedList.printListBackwards();

console.log("Shifting the first 2 nodes from the doubly linked list:");
myDoublyLinkedList.shift();
myDoublyLinkedList.shift();
myDoublyLinkedList.printList();
myDoublyLinkedList.printListBackwards();
