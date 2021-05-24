$(document).ready(function () {
    $('#akronInfoDiv').hide();
    $('#minneapolisInfoDiv').hide();
    $('#louisvilleInfoDiv').hide();

    $('#mainButton').click(function () {
        $('#mainInfoDiv').show();
        $('#akronInfoDiv').hide();
        $('#minneapolisInfoDiv').hide();
        $('#louisvilleInfoDiv').hide();
    })

    $('#akronButton').click(function() {
        $('#mainInfoDiv').hide();
        $('#akronInfoDiv').show();
        $('#akronWeather').hide();
        $('#minneapolisInfoDiv').hide();
        $('#louisvilleInfoDiv').hide();
    })

    $('#akronWeatherButton').click(function () {
        $('#akronWeather').toggle();
    })



    $('#minneapolisButton').click(function () {
        $('#mainInfoDiv').hide();
        $('#minneapolisInfoDiv').show();
        $('#minneapolisWeather').hide();
        $('#akronInfoDiv').hide();
        $('#louisvilleInfoDiv').hide();
    })

    $('#minneapolisWeatherButton').click(function () {
        $('#minneapolisWeather').toggle();
    })

    $('#louisvilleButton').click(function () {
        $('#mainInfoDiv').hide();
        $('#louisvilleInfoDiv').show();
        $('#louisvilleWeather').hide();
        $('#akronInfoDiv').hide();
        $('#minneapolisInfoDiv').hide();
    })

    $('#louisvilleWeatherButton').click(function () {
        $('#louisvilleWeather').toggle();
    })

    $("tr td").hover(
        // in callback
        function () {
            $(this).css("background-color", "WhiteSmoke");
        },
        // out callback
        function () {
            $(this).css("background-color", "");
        }
    );

});