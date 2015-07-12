function addCityToList() {
    var e = $('select#CitySelect')

    if (e.val() == 'Выберите регион' || e.val() == null) {
        return;
    }

    if (canAdd('city', e.val())) {
        var id = e.val().toString().replace(/\s/g, '_');
        var newVal = '<div class="city-block" id="' + id + '"><div class="city-title">'
            + e.val()
            + ' <span class="fa fa-trash-o like-link" onclick="removeFromList('
            + id + ')"></span></div></div>';

        $('div#listCity').append(newVal);
    }
}

function addRegionsToList() {
    var e = $('select#RegionSelect')

    if (e.val() == 'Выберите регион' || e.val() == null) {
        return;
    }

    if (canAdd('region', e.val())) {
        var id = e.val().toString().replace(/\s/g, '_');
        var newVal = '<div class="city-block" id="' + id + '"><div class="city-title">'
            + e.val()
            + ' <span class="fa fa-trash-o like-link" onclick="removeFromList('
            + id + ')"></span></div></div>';

        $('div#listRegions').append(newVal);
    }
}

function removeFromList(id) {
    if (id) {
        id.remove()
    }
}

function canAdd(type, name) {
    var list = null;

    if (type == 'city') {
        list = 'listCity';
    }
    if (type == 'region') {
        list = 'listRegions';
    }

    var items = $('[id=' + list + '] > div');

    if (items.length >= 10) {
        return false;
    }

    for (var i = 0; i < items.length; i++) {
        if (name == items[i].id.toString().replace(/_/g, ' ')) {
            return false;
        }
    }

    return true;
}