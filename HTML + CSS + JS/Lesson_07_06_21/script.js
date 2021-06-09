
// undefined
// number
// NaN
// string
// function
// boolean
// null
// object
// array

console.log("Hello World");

var x; // undefined

console.log(typeof(x));

x = 5; // number

console.log(typeof(x));

x = 'Hello'; // string

console.log(typeof(x));

x = [1,2,3]; // array as object

console.log(typeof(x));

x = {name: 'Israfil', age: 45};

console.log(typeof(x));

console.log(x.name);

x.name = function(){
    console.log('hey there');
}

x.name();

function foo2() {
   console.log(arguments[0]);
}

foo2(12,'Hello',23);

console.log = function(data)
{
    x.age += data;
}

function foo(){
    console.log('Hi');
}

x = function hello(){
    foo();
}

console.log(typeof(null))

console.log(typeof(x));

console.log(5 / 0);







