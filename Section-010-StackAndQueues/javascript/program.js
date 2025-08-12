import Stack from './Stack.js';

const stack = new Stack(1);
stack.push(2);
stack.push(3);
stack.printList();

console.log("Popped value:", stack.pop());
stack.printList();
