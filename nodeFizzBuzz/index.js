const max = process.argv[2];
console.log(max);

function fizzbuzz(max) {
  const arr = [];
  for(let x = 1; x<=max; x++){
    let val = "";
    if(x%3===0) val += "fizz";
    if(x%5===0) val += "buzz";
    if(val.length===0) val = x;
    arr.push(val);
  }
  return arr;
}

console.log(fizzbuzz(max));

module.exports = fizzbuzz;
