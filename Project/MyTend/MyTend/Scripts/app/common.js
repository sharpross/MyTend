$('#login').on('click', function () {
    $('#loginForm').modal();
});
$('#login2').on('click', function () {
    $('#loginForm').modal();
});
function showError(message) {
    $('.errorBox').html('<div class="alert alert-danger" role="alert">'+message+'</div>');
}

function hideTender(id) {
    $.ajax({
        type: 'POST',
        url: '/Tender/Hide',
        data: {
            id: id
        },
        success: function (data) {
            var el = $('#tenderrow-' + id);
            el.remove();
        }
    });
}

// add masked input for fields
const PASSWORD_INPUT = 'input[type="password"]';
const EMAIL_INPUT = 'input[type="email"]';
const SUBMIT_BUTTON = 'button[type="submit"]';

var checkIsPasswordIdentical = function () {
    if ($(PASSWORD_INPUT).length == 2) {
        pass1 = $(PASSWORD_INPUT)[0].val();
        pass2 = $(PASSWORD_INPUT)[0].val();

        $('button[type="submit"]').attr('disabled', pass1 !== pass2);
        if (pass2 !== pass2) {
            $(PASSWORD_INPUT).css('border', '1px solid #a94442');
        } else {
            $(PASSWORD_INPUT).css('border', '1px solid #ccc');
        }
    }
};

var emailValidation = function () {
    var email = $(EMAIL_INPUT);
    var re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/

    return re.test(email);
};

$(document).ready(function ($) {
    $('textarea').wysihtml5();
    $('input[name="Phone"]').mask("+7(999) 999-99-99");
    $(PASSWORD_INPUT).on('change', function () {

    });
    $(EMAIL_INPUT).on('change', function () {
        $('button[type="submit"]').attr('disabled', !emailValidation());
        $('.email-error').attr('hidden', !emailValidation());
    });
});

