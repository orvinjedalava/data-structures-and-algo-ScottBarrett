import Heap from './Heap.js';

const myHeap1 = new Heap();
myHeap1.insert(99);
myHeap1.insert(72);
myHeap1.insert(61);
myHeap1.insert(58);
myHeap1.print();

myHeap1.insert(100);
myHeap1.print();

myHeap1.insert(75);
myHeap1.print();

const myHeap2 = new Heap();
myHeap2.insert(95);
myHeap2.insert(75);
myHeap2.insert(80);
myHeap2.insert(55);
myHeap2.insert(60);
myHeap2.insert(50);
myHeap2.insert(65);
myHeap2.print();

myHeap2.remove();
myHeap2.print();

myHeap2.remove();
myHeap2.print();