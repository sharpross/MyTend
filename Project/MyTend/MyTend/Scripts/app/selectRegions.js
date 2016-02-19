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
                var sel = $('select[name=RegionId]');
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

    $('select[name=CountryId]').change(function (e) {
        var id = e.target.selectedOptions[0].id;
        $.ajax({
            url: '/Region/RegionById',
            data: {
                id: id
            },
            method: 'GET',
            success: function (resp) {
                var sel = $('select[name=RegionId]');
                
                if (resp.Data.length > 1) {
                    sel.empty();
                    sel.append('<option disabled selected>Выберите регион</option>');
                    closeCity();
                    for (var i = 0; i < resp.Data.length; i++) {
                        var value = '<option id="' + resp.Data[i].Id + '">' + resp.Data[i].Name + '</option>';
                        sel.append(value);
                    }
                } else {
                    sel.empty();
                    var value = '<option id="' + resp.Data[0].Id + '" selected>' + resp.Data[0].Name + '</option>';
                    sel.append(value);
                }
            }
        });
    });

    $('select[name=RegionId]').change(function (e) {
        var id = e.target.selectedOptions[0].id;
        $.ajax({
            url: '/Region/CityById',
            data: {
                id: id
            },
            method: 'GET',
            success: function (resp) {
                var sel = $('select[name=CityId]');
                if (resp.Data.length > 1) {
                    sel.empty();
                    sel.append('<option disabled selected>Выберите город</option>');
                    for (var i = 0; i < resp.Data.length; i++) {
                        var value = '<option id="' + resp.Data[i].Id + '">' + resp.Data[i].Name + '</option>';
                        sel.append(value);
                    }
                } else {
                    sel.empty();
                    var value = '<option id="' + resp.Data[0].Id + '" selected>' + resp.Data[0].Name + '</option>';
                    sel.append(value);
                }
            }
        });
    });

    function closeCity() {
        var sel = $('select[name=CityId]');
        sel.empty();
        sel.append('<option disabled selected>Выберите город</option>');
    }

    function closeRegions() {
        var sel = $('select[name=RegionId]');
        sel.empty();
        sel.append('<option disabled selected>Выберите регион</option>');
    }
});