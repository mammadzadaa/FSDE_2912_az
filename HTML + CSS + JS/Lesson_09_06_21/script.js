
function Clicked()
{
    let input = document.querySelector('#in');
    let data = input.value;
    input.value = '';
    
    //input.appendChild();
    
    let h = document.querySelector('h1');
    h.textContent = data;

    // let p = document.querySelector('.content .green#no');

    // p.classList.remove('green');
    // p.classList.add('red');

    // let p = document.getElementsByClassName('green')[0];
    // if(p != undefined){
    //     p.classList.remove('green');
    //     p.classList.add('red');
    // }
    // else{
    //     p = document.getElementsByClassName('red')[0];
    //     p.classList.remove('red');
    //     p.classList.add('green');
    // }


    console.log(data);
    //console.log(this);
    // console.log(document.body.children[2]);
    // console.dir(document.body.children[2]);
    // alert("Well Done");
}
// document.body.children[2].addEventListener("click",Clicked);

let btn = document.getElementById('click');


btn.addEventListener("click",Clicked);





// let input =  prompt("Some input");

// alert(input);

// let res = confirm("Is ok?");

// console.log(res);

// let str = "123as1";

// console.log(+str);
// console.log(parseInt(str));

//console.log(window.navigator.geolocation.getCurrentPosition(() => {alert("thanks")}));
console.log(navigator.deviceMemory);
// let res = confirm("Want to close?");
// if(res){
//     window.close();
// }
