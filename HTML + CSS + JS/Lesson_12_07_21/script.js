// import {GetAddAvatar as AddAvatar} from './modules/api.js';
// AddAvatar();


// import * as Api from './modules/api.js';
// Api.GetAddAvatar();


import('./modules/api.js').then((module)=>{
    module.GetAddAvatar()
})

class Animal{
    constructor(name){
        this.name = name;
    }

    speak(){
        console.log(`${this.name} makes a noise.`);
    }
}

class Dog extends Animal{
    constructor(name){
        super(name)
    }

    // speak(){
    //     super.speak();
    //     console.log(`${this.name} barks.`);
    // }
}

let d = new Dog('Rex');
d.speak();

console.log(d instanceof Animal);



class Polygon{
    constructor(...sides){
        this.sides = sides
    }
    
    
    static s = "str";
    static foo(){
        console.log('hi');
    }

    *getSides()
    {
        for(const side of this.sides){
            yield side;
        }
    }
}

console.log(Polygon.s)

let p = new Polygon('a','b','c','d');

console.log([...p.getSides()]);
Polygon.foo();

class Car{
    constructor(vendor,model){
        this.vendor = vendor
        this.model = model
    }


    set v(vendor){
        this.vendor = vendor
    }

    get v(){
        return this.vendor
    }

}


let c = new Car('BMW','M3')
console.log(`${c.model} ${c.vendor}`)

c.v = 'Mercedes'
console.log(c.v);
