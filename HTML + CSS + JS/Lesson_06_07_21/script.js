main();

async function main(){
    try{
        let data = await GetRequestAsync('https://api.github.com/users/mammadzadaa')
        console.log(data)
    }
    catch(error){
        console.error(error)
    }
}


function GetRequestAsync(url){
    return new Promise((resolve,reject)=>{
        let xhr = new XMLHttpRequest()
        xhr.open('GET',url)

        xhr.onload = function(){
            resolve(xhr.response)
        }

        xhr.onerror = function(){
            reject(new Error(xhr.statusText))
        }

        xhr.send();
    })
}



// let xhr = new XMLHttpRequest()
// xhr.open('GET','https://api.github.com/users/mammadzadaa',false)

// xhr.onloadend = function(){
//     console.log('loading....')
// }
// xhr.onloadend = function(){
//     console.log('DONE!')
// }

// xhr.send();

// let res = JSON.parse(xhr.response)
// console.log(res.login)


// const taskOne = new Promise((resolve,reject)=>{
//     reject('task One Done')
// })

// const taskTwo = new Promise((resolve,reject)=>{
//     resolve('task Two Done')
// })

// const taskThree = new Promise((resolve,reject)=>{
//     resolve('task Three Done')
// })


// Promise.all([
//     taskOne,
//     taskTwo,
//     taskThree
// ]).then((messages) => {
//     console.log(messages)
// }).catch((messages)=>{
//     console.log(messages)
// })

// const userLeft = false;
// const userWatchingCatVideos = true;

// let watchMyChanalePromise = new Promise((resolve,reject)=>{

//     if(userLeft){
//         reject({
//             name: 'User Left',
//             message: ':('
//         })
//     }
//     else if(userWatchingCatVideos){
//         reject({
//             name: 'User watchin cat videos',
//             message: 'Cat videos are more interresting'
//         })
//     }
//     else{
//         resolve('Thumbs up and subscribe!');
//     }  

// })

// watchMyChanalePromise.then((msg)=>{
//     console.log('Success: ' + msg)
// })
// .catch((error)=>{
//     console.log(error.name + ' ' + error.message)
// })



// let promise = new Promise(function(resolve,reject){
//     if(true)
//     {
//         resolve({
//             name : 'Hesen',
//             surname : 'Hesenov'
//         })
//     }
//     else{
//         reject('failure')
//     }
// })

// promise
// .then((msg) =>{
//     console.log(msg);
// })
// .catch((msg)=>{
//     console.log(msg);
// })
// .finally(()=>{
//     console.log('Finishito');
// })