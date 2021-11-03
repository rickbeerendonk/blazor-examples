var foo1;
var foo2;

for (var i = 0; i < 3; i++) {
  foo1 = () => console.log(i);
}

for (let i = 0; i < 3; i++) {
  foo2 = () => console.log(i);
}

foo1();
foo2();
