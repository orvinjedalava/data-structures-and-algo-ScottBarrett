import LinkedList from './LinkedList.js';

let myLinkedList_Pop = new LinkedList(7);
myLinkedList_Pop.push(4)
myLinkedList_Pop.printList();

let popped = myLinkedList_Pop.pop();
myLinkedList_Pop.printList();
console.log(`Popped value: ${popped.value}`);

popped = myLinkedList_Pop.pop();
myLinkedList_Pop.printList();
console.log(`Popped value: ${popped.value}`);