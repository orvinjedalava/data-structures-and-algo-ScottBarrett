// use a hash table to solve this problem
// given 2 arrays, create a function that let's a user know (true/false)
// whether these two arrays contain any common items
// For Example:
// const array1 = ['a', 'b', 'c', 'x'];
function itemInCommon(arr1, arr2) {
  let obj = {};
  for (let i = 0; i < arr1.length; i++) {
    obj[arr1[i]] = true;
  }

  for (let j = 0; j < arr2.length; j++) {
    if (obj[arr2[j]]) return true;
  }
  return false;
}

// this is O(2n) which is equivalent to => O(n)
let array1 = [1,3,5];
let array2 = [2,4,5];

console.log(itemInCommon(array1, array2));