import Node from './Node.js';

export default class Queue {
  constructor(value) {
    let newNode = new Node(value);

    this.first = newNode;
    this.last = newNode;
    this.length = 1;
  }

  printList() {
    console.log("length:", this.length);
    let currentNode = this.first;
    while(currentNode)
    {
      console.log(currentNode.value);
      currentNode = currentNode.next;
    }
  }

  enqueue(value) {
    let newNode = new Node(value);
    if (this.length === 0) {
      this.first = newNode;
      this.last = newNode;
    }
    else {
      this.last.next = newNode;
      this.last = newNode;
    }
    
    this.length++;

    return this;
  }

  dequeue() {
    if (this.length === 0) return undefined;

    let temp = this.first;

    if (this.length === 1) {
      this.first = null;
      this.last = null;
    }
    else {
      this.first = this.first.next;
    }
    
    temp.next = null;
    this.length--;
    
    return temp;
  }
}