$(document).ready(function () {
    if (openTabParam) {
        activaTab(openTabParam);
    }
});

function activaTab(tab) {
    $('.nav-tabs a[href="#' + tab + '"]').tab('show');
};