

const dbName = "customerDB";
let request = indexedDB.open(dbName);


request.onerror = function(event){
    console.log("Hello!")
    console.log(event);
}

request.onsuccess = function(event){
    
    let db = event.target.result;
    
    let transaction = db.transaction("customers","readonly");
    let customers = transaction.objectStore("customers");
    let r = customers.getAll();

    r.onsuccess = function(event){
        let cust = event.target.result;
        cust.forEach(c => {
            console.log(`${c.name} ${c.email}`)
        });
    }

}


// const customerData = [
//     {fin: "A3G5H8", name: "Samur", age: 21, email: "samurfromsheki@mail.ru"},
//     {fin: "R5TY67", name: "Muradxan", age: 21, email: "muradxanalsofromsheki@gmail.com"}
// ];

// const dbName = "customerDB";
// var request = indexedDB.open(dbName,1);

// request.onerror = function(event){
//     console.log(event);
// }

// request.onupgradeneeded = function(event){

//     var db = event.target.result;

//     var objectStore = db.createObjectStore("customers",{keyPath: "fin"});

//     objectStore.createIndex("name","name",{unique: false});

//     objectStore.createIndex("email","email",{unique: true});

//     objectStore.transaction.oncomplete = function(event){
//         var customerObjectStore = db.transaction("customers","readwrite").objectStore("customers");
//         customerData.forEach(function(customer){
//             customerObjectStore.add(customer);
//         })
//     }

// }