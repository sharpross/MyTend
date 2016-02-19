$('#login').on('click', function () {
    $('#loginForm').modal();
});

function showError(message) {
    $('.errorBox').html('<div class="alert alert-danger" role="alert">'+message+'</div>');
}