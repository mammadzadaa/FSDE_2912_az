
// console.log(this);

function afs()
{
    console.log(this)
}

afs();

let o = {
    name: 'Afti'
};

o.isAdmin = true;

delete o.isAdmin;

o['one two'] = 15;

function hello(){

    return 19;
}

let f = hello;

console.log(window.alert)

console.log(f);


console.log(o['one two']);

console.log(o);

let someObj = {
    name: 'Asif',
    surname: 'Mammadov',
    age : 35,
    skill : function(){
        console.log(this.age / 2);
    }
}

console.myfoo = function () {
    console.log("Do some crazy stuff")
}

console.myfoo();

function Car(model,year, hp) {
    this.aftandil = model,
    this.year = year,
    this.hp = hp,
    this.km = 0,
    this.Print = function () {
        console.log(`\nModel is ${this.aftandil}, Year is ${this.year} \nHp: ${this.hp}\n`)
    }
}

let mazda = new Car('CX9',2012,250);
mazda.km = 1200;
mazda.Print();

