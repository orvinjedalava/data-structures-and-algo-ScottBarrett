export default class HashTable {
  constructor(size = 7) {
    this.dataMap = new Array(size);
  }

  // determines what space a particular key will be stored in
  _hash(key) {
    let hash = 0;
    for (let i = 0; i < key.length; i++) {
      hash =  (hash + key.charCodeAt(i) * 23) % this.dataMap.length;
    }
    return hash;
  }
}