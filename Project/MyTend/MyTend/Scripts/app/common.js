$('#login').on('click', function () {
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