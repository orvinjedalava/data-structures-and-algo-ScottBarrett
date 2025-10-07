export default class HashTable {
  constructor(size = 7) {
    this.dataMap = new Array(size);
  }

  printTable() {
    for (let i = 0; i < this.dataMap.length; i++) {
      if (this.dataMap[i]) {
        console.log(`${i}: ${JSON.stringify(this.dataMap[i])}`);
      }
    }
  }

  // determines what space a particular key will be stored in
  _hash(key) {
    let hash = 0;
    for (let i = 0; i < key.length; i++) {
      hash =  (hash + key.charCodeAt(i) * 23) % this.dataMap.length;
    }
    return hash;
  }

  set(key, value) {
    let index = this._hash(key);
    
    // if index is completely empty, then we initialize it as an empty array
    if (!this.dataMap[index]) {
      this.dataMap[index] = [];
    }
    this.dataMap[index].push([key, value]);
    return this;
  }
}