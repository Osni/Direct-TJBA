//<!-- This code tells the browser to execute the "Initialize" method only when the complete document model has been loaded. -->
$(document).ready(function () {
    Initialize();
});
var map;
var markersArray = [];
// Where all the fun happens
function Initialize() {

    // Google has tweaked their interface somewhat - this tells the api to use that new UI
    google.maps.visualRefresh = true;
    var Liverpool = new google.maps.LatLng(-23.62062, -46.789055);

    // These are options that set initial zoom level, where the map is centered globally to start, and the type of map to show
    var mapOptions = {
        zoom: 14,
        center: Liverpool,
        mapTypeId: google.maps.MapTypeId.G_NORMAL_MAP
    };

    // This makes the div with id "map_canvas" a google map
    map = new google.maps.Map(document.getElementById("map_canvas"), mapOptions);

    // add a click event handler to the map object
    google.maps.event.addListener(map, "click", function (event) {
        // place a marker
        placeMarker(event.latLng);

        // display the lat/lng in your form's lat/lng fields
        document.getElementById("LatLng").value = document.getElementById("LatLng").value + event.latLng.lat() + " ; " + event.latLng.lng() + " # ";
        $("#pontos").append(event.latLng.lat() + " ; " + event.latLng.lng() + " <br /> ");
    });

}
function placeMarker(location) {
    // first remove all markers if there are any
    //deleteOverlays();

    var marker = new google.maps.Marker({
        position: location,
        map: map
    });
    marker.setIcon('http://maps.google.com/mapfiles/ms/icons/green-dot.png')
    // add marker in markers array
    markersArray.push(marker);

    //map.setCenter(location);
}

// Deletes all markers in the array by removing references to them
function deleteOverlays() {
    if (markersArray) {
        for (i in markersArray) {
            markersArray[i].setMap(null);
        }
        markersArray.length = 0;
    }
}