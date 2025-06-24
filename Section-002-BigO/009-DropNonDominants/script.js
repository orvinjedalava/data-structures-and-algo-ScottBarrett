// Drop Non-Dominants is a simple way to simplify Big O notation 
// by removing the less significant terms in a function's time complexity.

// instead of O(n^2 + n), we can simplify it to O(n^2)
function logItems(n) {
  for (let i = 0; i < n; i++) {
    for (let j = 0; j < n; j++) {
      console.log(i, j);
    }
  }

  // we can drop this loop in the notation since this is a non-dominant term
  for (let k = 0; k < n; k++) {
    console.log(k);
  }
}

logItems(10);