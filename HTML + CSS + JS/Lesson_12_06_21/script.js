
const e = document.getElementById('first');

// console.log(e);

// console.log(first);

//console.log(e.innerHTML);
//console.log(e.innerText);
//console.log(e.textContent);

// e.innerText = 'Hello world';
e.textContent = '<bold>STEP IT ACADEMY</bold>';
e.innerHTML = '<b>STEP IT ACADEMY</b>';
const p = document.createElement('p');
p.innerText = 'Lorem Lorem';
e.appendChild(p);
let elem = document.querySelector('.content :nth-child(3)');

elem.remove();
e.appendChild(elem);
// e.textContent = 'Hi There';

first.style.backgroundColor = "magenta";

