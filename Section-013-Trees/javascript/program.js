import BST from './BST.js';

const bst = new BST();
console.log(bst);

console.log('Building the initial tree...');
bst.insert(47);
bst.insert(21);
bst.insert(76);
bst.insert(18);
bst.insert(52);
bst.insert(82);
bst.printTree();

console.log('Inserting value of 27...');
bst.insert(27);
bst.printTree();