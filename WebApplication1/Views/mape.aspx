
@{
    ViewBag.Title = "map";
    Layout = "~/Views/Shared/Tamplet.cshtml";
}

<h2>map</h2>

<html>

<head>
    <title>
        google map autocomplete using google map api
    </title>
</head>
<body>
    <script src="https://maps.googleapis.com/maps/api/js?v=3.exp&sensor=false&libraries=places">
    </script>
    <script type="text/javascript">
    google.maps.event.addDomListener(window, 'load', intilize);
    function intilize() {
        var autocomplete = new google.maps.places.Autocomplete(document.getElementById("txtautocomplete"));

        google.maps.event.addListener(autocomplete, 'place_changed', function () {

        var place = autocomplete.getPlace();
        var location = "Address: " + place.formatted_address + "<br/>";
    location += "Latitude: " + place.geometry.location.lat() + "<br/>";
    location += "Longitude: " + place.geometry.location.lng();
        document.getElementById('lblresult').innerHTML = location
        });

    };

    </script>

    <span>location:</span><input type="text" id="txtautocomplete" style="width:200px" placeholder="enter the adress" />
    <label id="lblresult"></label>
</body>
</html>