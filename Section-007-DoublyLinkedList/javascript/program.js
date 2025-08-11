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

console.log("Push 4 values to the list:");
myDoublyLinkedList.push(4);
myDoublyLinkedList.push(5);
myDoublyLinkedList.push(6);
myDoublyLinkedList.push(7);
myDoublyLinkedList.printList();
myDoublyLinkedList.printListBackwards();

console.log("Get index 1:");
console.log(myDoublyLinkedList.get(1));

console.log("Get index 2:");
console.log(myDoublyLinkedList.get(2));

console.log("Set index 1 to 100:");
myDoublyLinkedList.set(1, 100);
myDoublyLinkedList.printList();

console.log("Insert 50 at index 2:");
myDoublyLinkedList.insert(2, 50);
myDoublyLinkedList.printList();

console.log("Remove index 2:");
myDoublyLinkedList.remove(2);
myDoublyLinkedList.printList();