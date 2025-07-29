import Node from './Node.js';

export default class DoublyLinkedList {
  constructor(value) {
    const newNode = new Node(value);
    this.head = newNode;
    this.tail = this.head;
    this.length = 1;
  }

  printList() {
    let currentNode = this.head;
    console.log("length:", this.length);
    while (currentNode) {
      console.log(currentNode.value);
      currentNode = currentNode.next;``
    }
  }

  printListBackwards() {
    let currentNode = this.tail;
    console.log("length:", this.length);
    while (currentNode) {
      console.log(currentNode.value);
      currentNode = currentNode.prev;
    }
  }

  // Add methods for the doubly linked list here
  push(value) {
    let newNode = new Node(value);
    if (!this.head) {
      this.head = newNode;
      this.tail = newNode;
    } else {
      this.tail.next = newNode;
      newNode.prev = this.tail;
      this.tail = newNode;
    }
    this.length++;
    return this;
  }

  pop() {
    if (this.length === 0) return undefined;

    let temp = this.tail;

    if (this.length === 1 ) {
      this.head = null;
      this.tail = null;
    } else {
      this.tail = this.tail.prev;
      this.tail.next = null;
      temp.prev = null;
      
    }
    this.length--;

    return temp;
  }
}