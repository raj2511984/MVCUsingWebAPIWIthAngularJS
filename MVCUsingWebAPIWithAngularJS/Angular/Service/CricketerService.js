app.service("CricketerService", function ($http) {
    this.GetCricketers = function () {        
        var req = $http.get('api/cricketer/getcricketers/');
        return req;
    }

    this.CricketerDetail = function (cricketerId) {
        var req = $http.get('api/cricketer/cricketerdetail/' + cricketerId);
        return req;
    }

    this.UpdateCricketer = function (cricketer) {
        var req = $http.post('api/cricketer/updatecricketer', cricketer);
        return req;
    }

    this.DeleteCricketer = function (Id) {
        var req = $http.get('api/cricketer/deletecricketer/' + Id + '');
        return req;
    }

    this.CricketerODIStats = function (cricketerId) {
        var req = $http.get('api/cricketer/cricketerdetail/ODIStats/' + cricketerId);
        return req;
    }


    this.CricketerTestStats = function (cricketerId) {
        var req = $http.get('api/cricketer/cricketerdetail/TestStats/' + cricketerId);
        return req;
    }
});