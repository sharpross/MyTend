function addTenderMessage() {
    var btn = $('button[id=addMessage]'),
        userId = $('input[name=UserId]').val(),
        temderId = $('input[name=TenderId]').val(),
        msg = $('textarea[name=Message]').val();

    var ani = new kamati.animation.dots(btn[0]);
    ani.start();

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
                ani.stop();
                window.location.reload();
            } else {
                ani.stop();
            }
        },
        error: function (resp) {
            ani.stop();
            window.location.reload();
        }
    });
}