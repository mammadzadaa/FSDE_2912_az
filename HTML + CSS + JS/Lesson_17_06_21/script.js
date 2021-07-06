document.cookie =  "username= Aqil; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";


let canvas = document.getElementById("myCanvas");

let _2d = canvas.getContext('2d');

_2d.moveTo(0, 0);
_2d.lineTo(300, 150);

_2d.beginPath();
_2d.arc(60, 60, 60, 2, 2 * Math.PI,true);
_2d.stroke();

console.log(_2d);