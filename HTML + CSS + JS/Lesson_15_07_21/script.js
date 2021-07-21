drawChart([30,10,75,50,5,10,35,80,15,1])

function drawChart(data){


/** @type{HTMLCanvasElement} */
let canvas = document.querySelector('#MyCanvas')
let context = canvas.getContext("2d")

let columnWidth = canvas.width / data.length
console.log(columnWidth)

let red = 255
for (let i = 0; i < data.length; i++) {
    context.fillStyle = `rgb(${red-=20},0,0)`
    context.fillRect(columnWidth * i,canvas.height,columnWidth-1, -data[i])
}
}

// let canvas = document.getElementById('MyCanvas')
// let context = canvas.getContext("2d")

// context.fillStyle = 'red'
// context.strokeStyle = 'blue'
// context.fillRect(50,50,250,250)
// context.strokeRect(200, 200, 100, 100);