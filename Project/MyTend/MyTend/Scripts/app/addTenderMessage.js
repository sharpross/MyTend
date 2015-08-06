function addTenderMessage() {
    var userId = $('input[name=UserId]').val(),
        temderId = $('input[name=TenderId]').val(),
        msg = $('textarea[name=Message]').val();

    $.ajax({
        type: 'POST',
        url: '/Tender/AddComment',
        data: {
            model: {
                Message: msg,
                UserId: userId,
                TenderId: temderId
            }
        },
        success: function (data) {
            if (data.Success) {
                window.location.reload();
            } else {
                
            }
        }
    });
}