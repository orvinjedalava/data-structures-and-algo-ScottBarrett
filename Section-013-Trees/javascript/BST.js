import Node from './Node.js';

export default class BST {
  constructor() {
    this.root = null;
  }

  printTree() {
    function inOrder(node) {
      if (!node) return;
      inOrder(node.left);
      console.log(node.value);
      inOrder(node.right);
    }
    inOrder(this.root);
  }

  insert(value) {
    const newNode = new Node(value);
    
    if (!this.root) {
      this.root = newNode;
      return this;
    }

    let temp = this.root;

    while (true) {
      if (newNode.value == temp.value) {
        return undefined; // No duplicates allowed
      }

      if (newNode.value < temp.value) {
        if (temp.left === null) {
          temp.left = newNode;
          return this;
        }
        temp = temp.left;
      } else {
        if (temp.right === null) {
          temp.right = newNode;
          return this;
        }
        temp = temp.right;
      }
    }
  } 
}