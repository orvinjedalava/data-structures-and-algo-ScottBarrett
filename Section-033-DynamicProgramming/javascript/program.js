let counter = 0;
let memo = [];

function fib(n) {
  counter++; 
  if (memo[n] !== undefined) {
    return memo[n];
  }
   
  if (n=== 0 || n === 1) {
    return n;
  }

  memo[n] = fib(n - 1) + fib(n - 2);
  return memo[n];
}

let counterBottomUp = 0;
function fibBottomUp(n) {
  let fibArray = [];
  fibArray[0] = 0;
  fibArray[1] = 1;

  for (let index = 2; index <= n; index++) {
    counterBottomUp++;
    fibArray[index] = fibArray[index - 1] + fibArray[index - 2];
  }

  return fibArray[n];
}

const n = 7;
console.log('\nFib of', n, '=', fib(n));
console.log('\nCounter =', counter);
console.log('\nFib of', n, '=', fibBottomUp(n));
console.log('\nCounter Bottom Up =', counterBottomUp);