import HashTable from './HashTable.js';

let myHashTable1 = new HashTable();
myHashTable1.set('lumber', 70);
myHashTable1.set('bolts', 1400);
myHashTable1.set('washers', 50);

console.table(myHashTable1.dataMap);

let myHashTable2 = new HashTable();
myHashTable2.set('bolts', 1400);
myHashTable2.set('washers', 50);

console.log(myHashTable2.get('bolts'));
console.log(myHashTable2.get('washers'));
console.log(myHashTable2.get('lumber')); // undefined