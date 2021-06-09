'use strict'

let xy = 5;

if (xy) {
    console.log('xy is defined');
}
else{
    console.log('xy is undefined!');
}

xy || console.log('xy is undefined!');

xy && console.log('xy is defined');

/**
 * @returns {} some info
 * @param {data} data info that I need 
 */
function DoSmth(data) {
    
}

DoSmth('Hello')

// k = 5;

// if(2 === '2')
// {
//     console.log('YES');
// }
// else if(2 == '2'){
//     console.log('Wow');
// }

// if(2 === +'2')
// {
//     console.log('YES');
// }


console.log('5' - 3);
console.log('5' + 3);
console.log('5'+ -3);
console.log(+'5' + -3);



console.log(undefined * 5);

function f()
{
    return 'Hi'
}

console.log(f());

console.log(a);


let x = 10;

const c = 21;

var a = 'Hello'; // window.a


if(true)
{
    let x = 5;
    console.log(x);
}

for (let i = '0'; i < 10; i++) {
    console.log(i);
    console.log(typeof(i));    
}

switch ('1') {
    case 1:
        console.log(x);
        break;

    default:
        console.log('Oh no');
        break;
}

