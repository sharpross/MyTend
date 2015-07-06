var RedirectHelper = {
    
    home: '/',

    redirectTo: function (params) {
        if (params) {
            window.location.pathname = params.path;
        }

        var newUrl = window.location.origin + this.home;
        window.location = newUrl;
    },

    redirectSelf: function (params) {
        if (params) {
            window.location.pathname = params.path;
        }

        window.location.pathname = this.home;
    }
}