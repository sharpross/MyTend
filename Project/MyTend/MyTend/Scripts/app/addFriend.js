function AddFriend(login) {
    $.ajax({
        type: 'POST',
        url: '/Card/Add',
        data: {
            login: login
        },
        success: function (data) {
            if (data.Success) {
                
            } else {
                
            }
        }
    });
}