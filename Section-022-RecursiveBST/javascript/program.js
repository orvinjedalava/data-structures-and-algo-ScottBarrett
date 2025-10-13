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

const bst3 = new BST();
console.log(bst3);

console.log('Building the initial tree...');
bst3.insert(47);
bst3.insert(21);
bst3.insert(76);
bst3.insert(18);
bst3.insert(27);
bst3.insert(52);
bst3.insert(82);
bst3.printTree();

console.log("\nMinValue from root:");
console.log(bst3.minValue(bst3.root));

console.log("\nMinValue from root->right:");
console.log(bst3.minValue(bst3.root.right));