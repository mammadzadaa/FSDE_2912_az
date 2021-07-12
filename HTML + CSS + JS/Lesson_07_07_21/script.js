// let response = fetch('https://api.github.com/users/GSmanXVI');
// response.then((x)=>{
//     x.json().then((y)=>{
//         //console.log(y)
//         let imgResponse = fetch(y.avatar_url)
//         imgResponse.then((r)=>{
//             r.blob().then((b)=>{
//                 console.log(b)
//                 let imgURL = URL.createObjectURL(b)
//                 document.getElementById('userPhoto').setAttribute('src',imgURL)
//             })
//         })
//     })
// });

GetAddAvatar();

async function GetAddAvatar() {
    let response = await fetch('https://api.github.com/users/GSmanXVI')
      let resJSON = await response.json()
        let imgResponse = await fetch(resJSON.avatar_url)
        let avatarBlob = await imgResponse.blob()
                console.log(avatarBlob)
                let imgURL = URL.createObjectURL(avatarBlob)
                document.getElementById('userPhoto').setAttribute('src',imgURL)    
}