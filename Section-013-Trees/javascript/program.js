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

console.log('Is 21 in the tree? ' , bst.contains(21) ? 'yes' : 'no');
console.log('Is 33 in the tree? ' , bst.contains(33) ? 'yes' : 'no');
console.log('Is 52 in the tree? ' , bst.contains(52) ? 'yes' : 'no');