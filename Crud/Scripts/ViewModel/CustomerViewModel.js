function CustomerDataViewModel() {
    var self = this;
    self.Name = ko.observable();
    self.Surname = ko.observable();
    self.TelephoneNumber = ko.observable();
    self.Address = ko.observable();
}

function CustomerViewModel(url) {
    var self = this;
    self.url = url;

    self.Data = ko.observable(new CustomerDataViewModel());

    self.SaveChanges = function (model, event) {

        var obj = ko.mapping.toJS(self.Data(), {
        });

        $.ajax({
            url: self.url,
            type: 'POST',
            contentType: "application/json; charset=utf-8",
            dataType: 'json',
            data: JSON.stringify(obj)
        })
        .success(function (data) {
            if (data.Result === "OK")
                window.location.href = data.Location;
            else {
                var errors = '';
                $(data.Errors).each(function (index, item) {
                    errors += '<li>' + item + '</li>'
                });
                errors = '<span>Wystąpiły następujące błędy:</span><ul>' + errors + '</ul>';
                $('#errors').html(errors);
            }
        }).fail(function () {
            alert("Żądanie nie powiodło się!");
        });
    }
}