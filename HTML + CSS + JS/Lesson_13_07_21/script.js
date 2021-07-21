
var map = new Microsoft.Maps.Map(document.getElementById('myMap'), {});

// let map, infoWindow;

// function initMap() {
//   map = new google.maps.Map(document.getElementById("map"), {
//     center: { lat: 40.4093, lng: 49.8671 },
//     zoom: 10,
//   });
//   infoWindow = new google.maps.InfoWindow();
//   const locationButton = document.createElement("button");
//   locationButton.textContent = "Pan to Current Location";
//   locationButton.classList.add("custom-map-control-button");


//   const zabilsLocationButton = document.createElement("button");
//   zabilsLocationButton.textContent = "Pan to Zabils Location";
//   zabilsLocationButton.classList.add("custom-map-control-button");

//   map.controls[google.maps.ControlPosition.TOP_CENTER].push(locationButton);
//   map.controls[google.maps.ControlPosition.TOP_LEFT].push(zabilsLocationButton);

//   zabilsLocationButton.addEventListener("click", ()=>{
//       const pos = {
//           lat: 24.4668,
//           lng: 39.5904
//       }
//     infoWindow.setPosition(pos);
//     infoWindow.setContent("Location found.");
//     infoWindow.open(map);
//     map.setCenter(pos);
//   })

//   locationButton.addEventListener("click", () => {
//     // Try HTML5 geolocation.
//     if (navigator.geolocation) {
//       navigator.geolocation.getCurrentPosition(
//         (position) => {
//           const pos = {
//             lat: position.coords.latitude,
//             lng: position.coords.longitude,
//           };
//           infoWindow.setPosition(pos);
//           infoWindow.setContent("Location found.");
//           infoWindow.open(map);
//           map.setCenter(pos);
//         },
//         () => {
//           handleLocationError(true, infoWindow, map.getCenter());
//         }
//       );
//     } else {
//       // Browser doesn't support Geolocation
//       handleLocationError(false, infoWindow, map.getCenter());
//     }
//   });
// }

// function handleLocationError(browserHasGeolocation, infoWindow, pos) {
//   infoWindow.setPosition(pos);
//   infoWindow.setContent(
//     browserHasGeolocation
//       ? "Error: The Geolocation service failed."
//       : "Error: Your browser doesn't support geolocation."
//   );
//   infoWindow.open(map);
// }