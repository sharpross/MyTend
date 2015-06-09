$(document).ready(function () {
    $('select[name=Country]').change(function (e) {
        var id = e.target.selectedOptions[0].id;
        $.ajax({
            url: '/Region/RegionById',
            data: {
                id: id
            },
            method: 'GET',
            success: function (resp) {
                var sel = $('select[name=Region]');
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
    $('select[name=Region]').change(function (e) {
        var id = e.target.selectedOptions[0].id;
        $.ajax({
            url: '/Region/CityById',
            data: {
                id: id
            },
            method: 'GET',
            success: function (resp) {
                var sel = $('select[name=City]');
                sel.empty();
                sel.append('<option disabled selected>Выберите горород</option>');
                for (var i = 0; i < resp.Data.length; i++) {
                    var value = '<option id="' + resp.Data[i].Id + '">' + resp.Data[i].Name + '</option>';
                    sel.append(value);
                }
            }
        });
    });

    function closeCity() {
        var sel = $('select[name=City]');
        sel.empty();
    }

    function closeRegions() {
        var sel = $('select[name=Regions]');
        sel.empty();
    }
});