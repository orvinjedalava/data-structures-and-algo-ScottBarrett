import LinkedList from './LinkedList.js';

let myLinkedList = new LinkedList(7);
myLinkedList.push(4)
myLinkedList.printList();

let popped = myLinkedList.pop();
myLinkedList.printList();
console.log(`Popped value: ${popped.value}`);

popped = myLinkedList.pop();
myLinkedList.printList();
console.log(`Popped value: ${popped.value}`);

let unshifted = myLinkedList.unshift(2);
myLinkedList.printList();
console.log(`Unshifted value: ${unshifted.head.value}`);

let shifted = myLinkedList.shift();
myLinkedList.printList();
console.log(`Shifted value: ${shifted.value}`);

myLinkedList.push(10);
myLinkedList.push(20);
myLinkedList.printList();

let getNode = myLinkedList.get(1);
console.log(`Node at index 1: ${getNode.value}`);

myLinkedList.set(1, 15);
myLinkedList.printList();

console.log(`Length of the list: ${myLinkedList.length}`);
myLinkedList.insert(1, 12);
myLinkedList.insert(0, 5);
myLinkedList.insert(4, 25);
console.log(`Length after insertions: ${myLinkedList.length}`);

myLinkedList.printList();