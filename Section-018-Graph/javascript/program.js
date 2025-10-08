import Graph from './Graph.js';

let myGraph1 = new Graph();
myGraph1.addVertex('A');
myGraph1.addVertex('B');
myGraph1.addVertex('C');

console.log(myGraph1.adjacencyList);

let myGraph2 = new Graph();
myGraph2.addVertex('A');
myGraph2.addVertex('B');
myGraph2.addVertex('C');
myGraph2.addEdge('A', 'B');
myGraph2.addEdge('A', 'C');

console.log(myGraph2.adjacencyList);