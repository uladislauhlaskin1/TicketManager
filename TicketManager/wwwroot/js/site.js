// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function DisplayLocations(locations) {

    //Set the Latitude and Longitude of the Map
    var cityCenter = new google.maps.LatLng(53.907466, 27.559047);

    //Create Options or set different Characteristics of Google Map
    var mapOptions = {
        center: cityCenter,
        zoom: 11,
        minZoom: 1,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };

    //Display the Google map in the div control with the defined Options
    var map = new google.maps.Map(document.getElementById("mapDiv"), mapOptions);

    //Setting markers
    locations.forEach(point => {
        console.log(point);
        console.log(point.latitude);
        console.log(point.longitude);
        var location = new google.maps.LatLng(point.latitude, point.longitude);
        var marker = new google.maps.Marker({
            position: location,
            animation: google.maps.Animation.DROP,
            title: point.name,
            //label: labels[labelIndex++ % labels.length],
        });
        marker.setMap(map);
    });
}