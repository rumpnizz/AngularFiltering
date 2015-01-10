var apiService = function($http) {
    var urlRegExp = /\/([A-Z]*)/ig;

    var isUrl = function (re, url) {
        return re.test(url);
    }

    var getRequest = function (url) {
        if (!isUrl(urlRegExp, url)) {
            alert(url + ' is not a valid url');
            return;
        }

        var self = this;

        $http.get(url)
            .success(function(data, status, headers, config) {
                self = data;
            })
            .error(function(data, status, headers, config) {
                alert('error:' + status);
            });
    }

    var postRequest = function(productModel) {
        return false;
    }

    return {
        get: getRequest,
        post: postRequest
    }
};

apiService.$inject = ['$http'];