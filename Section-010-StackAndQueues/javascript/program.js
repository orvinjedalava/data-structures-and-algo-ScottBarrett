import Queue from './Queue.js';
import Stack from './Stack.js';

const stack = new Stack(1);
stack.push(2);
stack.push(3);
stack.printList();

console.log("Popped value:", stack.pop());
stack.printList();

const queue = new Queue(1);
queue.enqueue(2);
queue.enqueue(3);
queue.printList();

console.log("Dequeued value:", queue.dequeue());
queue.printList();

console.log("Dequeued value:", queue.dequeue());
queue.printList();

console.log("Queue value 5");
queue.enqueue(5);
queue.printList();
