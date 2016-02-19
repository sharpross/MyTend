$(document).ready(function () {

    $('select[id=subCountrysSelect]').change(function (e) {
        var id = e.target.selectedOptions[0].id;
        $.ajax({
            url: '/Region/RegionById',
            data: {
                id: id
            },
            method: 'GET',
            success: function (resp) {
                var sel = $('select[id=subRegionSelect]');
                sel.empty();
                sel.append('<option disabled selected>Выберите регион</option>');
                closeCity();
                for (var i = 0; i < resp.Data.length; i++) {
                    var value = '<option id="' + resp.Data[i].Id + '">' + resp.Data[i].Name + '</option>';
                    sel.append(value);
                }
            }
        });
    });
    $('select[id=subRegionSelect]').change(function (e) {
        var id = e.target.selectedOptions[0].id;
        $.ajax({
            url: '/Region/CityById',
            data: {
                id: id
            },
            method: 'GET',
            success: function (resp) {
                var sel = $('select[id=subCitySelect]');
                sel.empty();
                sel.append('<option disabled selected>Выберите город</option>');
                for (var i = 0; i < resp.Data.length; i++) {
                    var value = '<option id="' + resp.Data[i].Id + '">' + resp.Data[i].Name + '</option>';
                    sel.append(value);
                }
            }
        });
    });

    function closeCity() {
        var sel = $('select[id=CityId]');
        sel.empty();
        sel.append('<option disabled selected>Выберите город</option>');
    }

    function closeRegions() {
        var sel = $('select[id=RegionId]');
        sel.empty();
        sel.append('<option disabled selected>Выберите регион</option>');
    }

});

function addCityToList() {
    var e = $('select#subCitySelect')

    if (e.val() == 'Выберите город' || e.val() == null) {
        return;
    }

    if (canAdd('city', e.val())) {
        var id = e.val().toString().replace(/\s/g, '_');
        var newVal = '<div class="city-block" id="' + id + '"><div class="city-title">'
            + e.val()
            + ' <span class="fa fa-times red like-link" onclick="removeFromList('
            + 'this' + ')"></span></div></div>';

        $('div#listCity').append(newVal);

        SaveSubCitys();
    }
}

function addRegionsToList() {
    var e = $('select#subRegionSelect')

    if (e.val() == 'Выберите регион' || e.val() == null) {
        return;
    }

    if (canAdd('region', e.val())) {
        var id = e.val().toString().replace(/\s/g, '_');
        var newVal = '<div class="city-block" id="' + id + '"><div class="city-title">'
            + e.val()
            + ' <span class="fa fa-times red like-link" onclick="removeFromList('
            + 'this' + ')"></span></div></div>';

        $('div#listRegions').append(newVal);

        SaveSubCitys();
    }
}

function removeFromList(id) {
    if (id) {
        id.parentElement.parentElement.remove();
        SaveSubCitys();
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

    if (list == "listRegions" && items.length > 4) {
        return false;
    }

    if (list == "listCity" && items.length > 10) {
        return false;
    }

    for (var i = 0; i < items.length; i++) {
        if (name == items[i].id.toString().replace(/_/g, ' ')) {
            return false;
        }
    }

    return true;
}

function SaveSubCitys()
{
    var citys = [],
        regions = [],
        listCitys = $('div[id=listCity]').children(),
        listRegions = $('div[id=listRegions]').children();


    for (var i = 0; i < listCitys.length; i++) {
        citys.push(listCitys[i].id.toString().replace(/_/g, ' '));
    }

    for (var i = 0; i < listRegions.length; i++) {
        regions.push(listRegions[i].id.toString().replace(/_/g, ' '));
    }

    $.ajax({
        url: '/Account/UpdateSubRegions',
        data: {
            model: {
                Citys: citys,
                Regions: regions
            }
        },
        method: 'POST',
        success: function (resp) {
            
        }
    });
}