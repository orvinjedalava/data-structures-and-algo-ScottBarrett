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

  unshift(value) {
    let newNode = new Node(value);
    if (!this.head) {
      this.head = newNode;
      this.tail = newNode;
    }
    else {
      newNode.next = this.head;
      this.head.prev = newNode;
      this.head = newNode;
    }

    this.length++;

    return this;
  }

  shift() {
    if (this.length === 0) return undefined;

    let temp = this.head;

    if (this.length === 1) {
      this.head = null;
      this.tail = null;
    }
    else {
      this.head = this.head.next;
      this.head.prev = null;
      temp.next = null;
    }

    this.length--;

    return temp;
  }

  get(index) {
    if (this.length === 0 || index < 0 || index >= this.length) {
      return undefined;
    }

    let temp = null;

    if (index < this.length / 2) {
      temp = this.head;
      for (let i = 0; i < index; i++ ) {
        temp = temp.next;
      }
    } else {
      temp = this.tail;
      for (let i = this.length - 1; i > index; i-- ) {
        temp = temp.prev;
      }
    }

    return temp;
  }

  set(index, value) {
    let temp = this.get(index);

    if (temp)
    {
      temp.value = value;
      return true;
    }
    else {
      return false;
    }
  }

  insert(index, value) {
    if (index < 0 || index > this.length) {
      return false;
    }

    if (index == 0 )
      return this.unshift(value);

    if (index == this.length)
      return this.push(value);

    let newNode = new Node(value);
    let before = this.get(index - 1);
    let after = before.next;
    before.next = newNode;
    newNode.prev = before;
    newNode.next = after;
    after.prev = newNode;
    this.length++;
    return newNode;
  }
}