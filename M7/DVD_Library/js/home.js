$(document).ready(function () {
    loadAllDVDs();
    $('#add-form').hide();
    $('#edit-form').hide();
    $('#displayDetail').hide();
});


function loadAllDVDs() {
    clearDVDDisplay();
    
    $('#main-page-error-messages').empty();
    
    var DVDdisplaytable = $('#contentRows');
    $.ajax({
        type: 'GET',
        url: 'https://tsg-dvds.herokuapp.com/dvds',
        success: function (data) {
            $.each(data, function (index, dvd) {
                var title = dvd.title;
                var releaseYear = dvd.releaseYear;
                var director = dvd.director;
                var rating = dvd.rating;
                var notes = dvd.notes;
                var id = dvd.id;

                var row = '<tr>';
                row += '<td><a href="#" onclick="displayDVD(' + id + ')">' + '<u>' + title + '</u>' + '</a></td>';
                row += '<td>' + releaseYear + '</td>';
                row += '<td>' + director + '</td>';
                row += '<td>' + rating + '</td>';
                row += '<td><a href="#" onclick="getDVDToEdit(' + id + ')"> <u> Edit</u> </a>' + " | " + '<a href="#" onclick="deleteDVD(' + id + ')"> <u> Delete</u></a></td>';
                row += '</tr>';

                DVDdisplaytable.append(row);

            })
        },
        error: function () {
            $('#main-page-error-messages')
                .append($('<li>')
                    .attr({ class: 'list-group-item list-group-item-danger' })
                    .text('Error calling web service. Please try again later.'));
        }
    });
}


function displayDVD(id) {

    $('#display-detail-error-messages').empty();

    $('#mainPage').hide();
    $('#displayDetail').show();

    $.ajax({
        type: 'GET',
        url: 'https://tsg-dvds.herokuapp.com/dvd/' + id,
        success: function (data, status) {
            $('#displayTitle').text(data.title);
            $('#displayYear').text(data.releaseYear);
            $('#displayDirector').text(data.director);
            $('#displayRating').text(data.rating);
            $('#displayNotes').text(data.notes);
        },
        error: function () {
            $('#display-detail-error-messages')
                .append($('<li>')
                    .attr({ class: 'list-group-item list-group-item-danger' })
                    .text('Error calling web service.  Please try again later.'));
        }
    });
}


$('#displayBack').click(function () {

    $('#mainPage').show();
    $('#displayDetail').hide();
});



$('#create-dvd-button').on('click', function () {

    $('#add-form').show();
    $('#add-form')[0].reset();
    $('#mainPage').hide();
});


$('#add-button').on('click', function () {

    var year = $('#add-release-year').val();

    if (year.length != 4 || isNaN(year) == true) {

        $('#create-dvd-error-messages')
            .append($('<li>')
                .attr({ class: 'list-group-item list-group-item-danger' })
                .text('Please enter a 4-digit year.'));

        return false;
    }

    var title = $('#add-title').val();

    if (title == '' || title === null) {
        $('#create-dvd-error-messages')
            .append($('<li>')
                .attr({ class: 'list-group-item list-group-item-danger' })
                .text('A title field is required.'));

        return false;

    }

    $.ajax({
        type: 'POST',
        url: 'https://tsg-dvds.herokuapp.com/dvd',
        data: JSON.stringify({
            title: $('#add-title').val(),
            releaseYear: $('#add-release-year').val(),
            director: $('#add-director').val(),
            rating: $('#add-rating').val(),
            notes: $('#add-notes').val()
        }),
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        'dataType': 'json',
        success: function () {
            $('#create-dvd-error-messages').empty();
            loadAllDVDs();
            $('#mainPage').show();
            $('#add-form').hide();
        },
        error: function () {
            loadAllDVDs();
            $('#create-dvd-error-messages')
                .append($('<li>')
                    .attr({ class: 'list-group-item list-group-item-danger' })
                    .text('Error calling web service. Please try again later.'));

        }
    });

});

$('#cancel-add-button').on('click', function () {
    $('#create-dvd-error-messages').empty();
    loadAllDVDs();
    $('#mainPage').show();
    $('#add-form').hide();
});


function getDVDToEdit(id) {

    $.ajax({
        type: 'GET',
        url: 'https://tsg-dvds.herokuapp.com/dvd/' + id,
        success: function (data, status) {
            var headerTitle = data.title;
            $('#edit-title').val(data.title);
            $('#edit-release-year').val(data.releaseYear);
            $('#edit-director').val(data.director);
            $('#edit-rating').val(data.rating);
            $('#edit-notes').val(data.notes);
            $('#edit-dvdid').val(data.id);
            $('h2').text('Edit Dvd: ' + headerTitle);
           
            $('#edit-form').show();
            $('#mainPage').hide();
        },
        error: function () {
            $('#main-page-error-messages')
                .append($('<li>')
                    .attr({ class: 'list-group-item list-group-item-danger' })
                    .text('Error calling web service. Please try again later.'));
        }
    });
}

$('#save-changes-button').on('click', function () {

    var year = $('#edit-release-year').val();

    if (year.length != 4 || isNaN(year) == true) {

        $('#edit-dvd-error-messages')
            .append($('<li>')
                .attr({ class: 'list-group-item list-group-item-danger' })
                .text('Please enter a 4-digit year.'));

        return false;
    }

    var title = $('#edit-title').val();

    if (title == '' || title === null) {
        $('#edit-dvd-error-messages')
            .append($('<li>')
                .attr({ class: 'list-group-item list-group-item-danger' })
                .text('A title field is required.'));

        return false;

    }

    $.ajax({
        type: 'PUT',
        url: 'https://tsg-dvds.herokuapp.com/dvd/' + $('#edit-dvdid').val(),
        data: JSON.stringify({
            id: $('#edit-dvdid').val(),
            title: $('#edit-title').val(),
            releaseYear: $('#edit-release-year').val(),
            director: $('#edit-director').val(),
            rating: $('#edit-rating').val(),
            notes: $('#edit-notes').val()
        }),
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        'success': function () {
            $('#edit-form').hide();
            loadAllDVDs();
            $('#mainPage').show();
        },
        'error': function () {
            loadAllDVDs();
            $('#edit-dvd-error-messages')
                .append($('<li>')
                    .attr({ class: 'list-group-item list-group-item-danger' })
                    .text('Error calling web service. Please try again later.'));
        }
    });
});


$('#cancel-edit-button').on('click', function () {
    $('#edit-dvd-error-messages').empty();
    loadAllDVDs();
    $('#mainPage').show();
    $('#edit-form').hide();
});


function deleteDVD(id) {

    var confirm = window.confirm("Are you sure you want to delete this Dvd from your collection?");
    if (confirm == true) {
        $.ajax({
            type: 'DELETE',
            url: 'https://tsg-dvds.herokuapp.com/dvd/' + id,
            success: function (status) {
                loadAllDVDs();
            }
        });

    } else {
        loadAllDVDs();
    }
}


$("#search-button").click(function (event) {

    if ($('#search-term').val() == "" || $('#search-category').val() == "") {

        $('#main-page-error-messages')
            .append($('<li>')
                .attr({ class: 'list-group-item list-group-item-danger' })
                .text('Both search dropdown and search text box are required.'));

        return false;
    }

    clearDVDDisplay();
    var contentRows = $('#contentRows');

    $.ajax({
        type: 'GET',
        url: 'https://tsg-dvds.herokuapp.com/dvds/' + $('#search-category').val() + "/" + $('#search-term').val(),
        success: function (data, status) {
            $.each(data, function (index, dvd) {
                var title = dvd.title;
                var date = dvd.releaseYear;
                var dir = dvd.director;
                var rate = dvd.rating;
                var id = dvd.id;

                var row = '<tr>';
                row += '<td><a href="#" onclick="displayDVD(' + id + ')">' + '<u>' + title + '</u>' + '</a></td>';
                row += '<td>' + date + '</td>';
                row += '<td>' + dir + '</td>';
                row += '<td>' + rate + '</td>';
                row += '<td><a href="#" onclick="getDVDToEdit(' + id + ')"> <u> Edit</u> </a>' + " | " + '<a href="#" onclick="deleteDVD(' + id + ')"> <u> Delete</u></a></td>';
                row += '</tr>';

                contentRows.append(row);
                
                $('#search-term').clear();
            })
        },
        error: function () {
            $('#main-page-error-messages')
                .append($('<li>')
                    .attr({ class: 'list-group-item list-group-item-danger' })
                    .text('Error calling web service. Please try again later.'));
        }
    })
});


function clearDVDDisplay() {
    $('#contentRows').empty();
}




