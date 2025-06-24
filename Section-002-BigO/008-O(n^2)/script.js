// The function is O(n^2) - an n-raise-to-2 operation.
// We pass the parameter n and the operation ran n-raise-to-2.
// A O(n^2) operation is generally considered an inefficient code.

function logItems(n) {
    for(let i = 0; i < n; i++) {
      for (let j = 0; j < n; j++) {
        console.log(i, j);
      }
    }
    
}

logItems(10)