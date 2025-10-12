import BST from './BST.js';

const bst1 = new BST();
console.log(bst1);

console.log('Building the initial tree...');
bst1.insert(47);
bst1.insert(21);
bst1.insert(76);
bst1.insert(18);
bst1.insert(27);
bst1.insert(52);
bst1.insert(82);
bst1.printTree();

console.log('\nBST Contains 27:');
console.log(bst1.contains(27) ? 'yes' : 'no');

console.log('\nBST Contains 17:');
console.log(bst1.contains(17) ? 'yes' : 'no');

const bst2 = new BST();
bst2.rInsert(2);
bst2.rInsert(1);
bst2.rInsert(3);

bst2.printTree();