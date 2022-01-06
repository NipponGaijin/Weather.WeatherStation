$(function () {
    $('.list-elem').click(function (event) {
        weather.weatherStation.devices.device.getSensorsByDeviceId(event.currentTarget.id)
            .then(function (data) {
                console.log(data)
            });
        
    })
});
