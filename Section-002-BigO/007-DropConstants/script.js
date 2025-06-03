// The function is O(2n) - an O-of-2n operation.
// We pass the parameter n and the operation ran n-times-2.

// First rule to simplify operations is to "Drop Constants"
// Meaning, from 0(2n) ( or 3n / 4n/ 5n ), let's make it O(n)

function logItems(n) {
    for(let i = 0; i < n; i++) {
        console.log(i)
    }
    for (let j = 0; j < n; j++) {
      console.log(j);
    }
}

logItems(10)