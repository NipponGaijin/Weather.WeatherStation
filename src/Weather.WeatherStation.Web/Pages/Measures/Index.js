$(function () {
    var chartContainer = $('#chart');

    var sensorId = new URLSearchParams(document.location.search).get('sensorId');
    var deviceId = new URLSearchParams(document.location.search).get('deviceId');

    weather.weatherStation.sensors.sensor.getMeasuresBySensorId(sensorId)
        .then(function (data) {
            var chartData = data.map(function (item) {
                return { y: item.temperature, x: item.creationTime }
            });

            console.log(chartData);

            var chart = new Chart(chartContainer, {
                type: 'line',
                data: {
                    labels: chartData.map(function (item) {
                        var date = new Date(item.x)
                        return date;
                    }),
                    datasets: [
                        {
                            label: 'Температура',
                            data: chartData,
                            fill: true,
                            backgroundColor: randomColor(0.3),
                            borderColor: randomColor(1),
                            lineTension: 0
                        }
                    ]
                },
                options: {
                    scales: {
                        xAxes: [{
                            display: false //this will remove all the x-axis grid lines
                        }]
                    }
                }
            });
            console.log(chart);
        });

    $('#back-btn').click(function (event) {
        window.location = '/Sensors?deviceId=' + deviceId;
    });
});

function randomColor(opacity) {
    var color = 'rgba(' + Math.random() * 255 + ', ' + Math.random() * 255 + ', ' + Math.random() * 255 + ', ' + opacity + ')';
    console.log(color);
    return color;
}