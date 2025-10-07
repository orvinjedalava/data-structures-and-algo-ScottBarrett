import HashTable from './HashTable.js';

let myHashTable = new HashTable();
myHashTable.set('lumber', 70);
myHashTable.set('bolts', 1400);
myHashTable.set('washers', 50);

console.table(myHashTable.dataMap);