$(document).ready(function () {
    $('H1').addClass('text-center');
    $('H2').addClass('text-center');
    $('.myBannerHeading').addClass('page-header').removeClass('.myBannerHeading');
    $('#yellowHeading').text('Yellow Team');
    $('#orangeTeamList').css({ 'background-color': 'orange' });
    $('#blueTeamList').css({ 'background-color': 'blue' });
    $('#redTeamList').css({ 'background-color': 'red' });
    $('#yellowTeamList').css({ 'background-color': 'yellow' });
    $('#yellowTeamList').append('<li>Joseph Banks</li>');
    $('#yellowTeamList').append('<li>Simon Jones</li>');
    $('H1:contains("HIDE ME!!!")').hide();
    $('#footerPlaceholder').remove();
    $('#footer').append('<p>Drew McPherson drew.mcpherson.101@gmail.com</p>');
    $('#footer').addClass('text-center');
    $('#footer').css({'font-family': 'Courier','font-size':'24px'});






});