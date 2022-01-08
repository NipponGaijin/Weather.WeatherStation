$(function () {
    let deviceId = new URLSearchParams(document.location.search).get('deviceId');

    $('#back-btn').click(function (event) {
        window.location = '/';
    });

    $('.list-elem').click(function (event) {
        weather.weatherStation.sensors.sensor.getMeasuresBySensorId(event.currentTarget.id)
            .then(function (data) {
                var queryParams = {
                    sensorId: event.currentTarget.id,
                    deviceId: deviceId
                }
                const queryUrlParams = new URLSearchParams(queryParams);

                window.location = '/Measures?' + queryUrlParams.toString();
            });
    });
});