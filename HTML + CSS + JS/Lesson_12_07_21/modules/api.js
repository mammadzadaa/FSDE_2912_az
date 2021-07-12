
async function GetAddAvatar() {
    console.log('Hello');
    let response = await fetch('https://api.github.com/users/GSmanXVI')
      let resJSON = await response.json()
        let imgResponse = await fetch(resJSON.avatar_url)
        let avatarBlob = await imgResponse.blob()
                console.log(avatarBlob)
                let imgURL = URL.createObjectURL(avatarBlob)
                document.getElementById('userPhoto').setAttribute('src',imgURL)    
}




export {GetAddAvatar}