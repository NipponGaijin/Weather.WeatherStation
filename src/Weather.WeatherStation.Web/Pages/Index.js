$(function () {
    $('.list-elem').click(function (event) {
        window.location = '/Sensors?deviceId=' + event.currentTarget.id;
    });
});
