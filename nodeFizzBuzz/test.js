const Lab = require('lab');
const lab = exports.lab = Lab.script();
const {expect} = require("code");
const fizzbuzz = require("./index");

lab.test(`does fizz and buzz`, done => {
  const actual = fizzbuzz(5);
expect(actual).to.equal([1,2,"fizz",4,"buzz"]);
done();
});

lab.test(`does fizzbuzz`, done => {
  const actual = fizzbuzz(15);
expect(actual[14]).to.equal("fizzbuzz");
done();
});
