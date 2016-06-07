
$(document).ready(function () {
    var loginBtn = $('button[name=LoginButton]');
    var logoutBtn = $('a[name=LogoutButton]');

    if (loginBtn.length > 0) {
        loginBtn.bind('click', function (el) {
            var ani = new kamati.animation.dots(el.currentTarget);
            ani.start();

            var login = $('input[name=Login]').val();
            var password = $('input[name=Password]').val();
            var rememberMe = $('input[name=RememberMe]').val();
            $.ajax({
                type: 'POST',
                url: '/Account/Login',
                data: {
                    login: login,
                    password: password
                },
                success: function (data) {
                    ani.stop();
                    if (data.Success) {
                        RedirectHelper.redirectTo();
                    } else {
                        $('.LoginError').text(data.Data);
                    }
                },
                error: function (data) {
                    ani.stop();
                    $('.LoginError').text(data.responseJSON.Data);
                }
            });
        });
    }

    if (logoutBtn.length > 0) {
        logoutBtn.bind('click', function (el) {
            var ani = new kamati.animation.dots(el.currentTarget);
            ani.start();
            $.ajax({
                type: 'POST',
                url: '/Account/Logout',
                success: function (data) {
                    ani.stop();
                    if (data.Success) {
                        RedirectHelper.redirectTo();
                    }
                }
            });
        });
    }
});

