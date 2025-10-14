import BST from './BST.js';

const bst1 = new BST();
bst1.insert(47);
bst1.insert(21);
bst1.insert(76);
bst1.insert(18);
bst1.insert(27);
bst1.insert(52);
bst1.insert(82);

console.log('Initial:');
bst1.printTree();

console.log('Breadth-First Search:');
console.log(bst1.BFS());