var add = true;

$(document).ready(function () {
    if (add === false) {
        $('#id_add_span').addClass('glyphicon-plus');
    }
    else {
        $('#id_add_span').addClass('glyphicon-home');
    }
});

$(document).ready(function () {
    $('#id_cog').click(function () {
        $('#id_fil').slideToggle("fast");
    });
});

$(document).ready(function () {
    $('#id_add').click(function () {
        if (add === false) {
            add = true;
        }
        else if (add===true) {
            add = false;
        }
    });
});