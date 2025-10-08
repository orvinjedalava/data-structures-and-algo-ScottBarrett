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

let myGraph3 = new Graph();
myGraph3.addVertex('A');
myGraph3.addVertex('B');
myGraph3.addVertex('C');
myGraph3.addEdge('A', 'B');
myGraph3.addEdge('B', 'C');
myGraph3.addEdge('C', 'A');

console.log(myGraph3.adjacencyList);
myGraph3.removeEdge('A', 'B');
console.log(myGraph3.adjacencyList);

let myGraph4 = new Graph();
myGraph4.addVertex('A');
myGraph4.addVertex('B');
myGraph4.addVertex('C');
myGraph4.addVertex('D');
myGraph4.addEdge('A', 'B');
myGraph4.addEdge('A', 'C');
myGraph4.addEdge('B', 'D');
myGraph4.addEdge('C', 'D');
myGraph4.addEdge('D', 'A');

console.log(myGraph4.adjacencyList);
myGraph4.removeVertex('D');
console.log(myGraph4.adjacencyList);