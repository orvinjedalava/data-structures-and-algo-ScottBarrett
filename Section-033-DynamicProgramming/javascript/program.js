let counter = 0;
let memo = [];

function fib(n) {
  if (memo[n] !== undefined) {
    return memo[n];
  }

  if (n=== 0 || n === 1) {
    return n;
  }

  counter++;

  memo[n] = fib(n - 1) + fib(n - 2);
  return memo[n];
}

const n = 7;
console.log('\nFib of', n, '=', fib(n));
console.log('\nCounter =', counter);