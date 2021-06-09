let input = prompt('Enter your name:');


console.log(input);

// let obj = {};
// console.log(typeof(obj));

// let arr = [];
// console.log(typeof(arr));

let myarr = [1,'fdsfs',21.4,true,function name() {alert("Hello")}];

// myarr[4]();

// for (let i = 0; i < myarr.length; i++) {

//     console.log(myarr[i]);   
// }

// console.log(myarr);



myarr.forEach(element => console.log(element));

let numarr = [1,2,3,4,5];

numarr.push(99);
let r = numarr.pop();

numarr.unshift(99);
numarr.shift();

// numarr.splice(2,1); // removes

// numarr.splice(2,0,99,88,10); // adds

// numarr.splice(-1,0,99); // not good practice

// let newArr = numarr.concat([33,34,35]);

// let newArr = numarr.slice(2,4);

// let newArr = numarr.reverse();

// let newArr = numarr.indexOf(4);
// let newArr = numarr.filter(x => x%2 == 0);

let newArr = numarr.every(x => x > 50);


console.log(newArr);

// numarr[10] = 3;
// delete numarr[1];

// console.log(numarr[8]);

// numarr.asd = 'hello';

// for (const item of numarr) {
//     console.log(item);
// }

// for (const key in numarr) {
    
//     console.log(key); 
//     console.log(numarr[key]);
// }

