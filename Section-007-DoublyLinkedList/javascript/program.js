import DoublyLinkedList from "./DoublyLinkedList.js";

console.log("Doubly Linked List Example");
const myDoublyLinkedList = new DoublyLinkedList(7);
myDoublyLinkedList.printList();

console.log("Adding nodes to the doubly linked list via push:");
myDoublyLinkedList.push(10);
myDoublyLinkedList.push(15);
myDoublyLinkedList.printList();
myDoublyLinkedList.printListBackwards();