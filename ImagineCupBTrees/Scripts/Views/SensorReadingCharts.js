getSensorData();

function getSensorData()
{
    $.ajax({
        method: "GET",
        url: appName + "/api/SensorReadings",
        data: {},
        success: function (data, textStatus, jqXHR) {
            var sortedArrays = sortSensorReadingDataByVariable(data);
            makeCharts(sortedArrays);
        },
        error: function (jqXHR, status, error) {
            alert(error);
        }
    });
}

function sortSensorReadingDataByVariable(data)
{
    var humidityArr = [];
    var tempArr = [];
    var lightArr = [];
    var dateArr = [];

    var len = data.length;
    for (var i = 0; i < len; i++)
    {
        humidityArr.push(data[i].Humidity);
        tempArr.push(data[i].TemperatureF);
        lightArr.push(data[i].Lux);
        dateArr.push(data[i].DateAdded);
    }

    var sortedArrays = {};
    //sortedArrays.humidityData = 
    //    { 
    //        datasets: [{
    //            label: "Humidity",
    //            data: humidityArr,
    //            fill: false
    //        }]
    //    };
    sortedArrays.humidityData = [{
        x: dateArr,
        y: humidityArr,
        type: 'scatter'
    }];

    sortedArrays.temperatureData = [{
        x: dateArr,
        y: tempArr,
        type: 'scatter'
    }];

    sortedArrays.lightData = [{
        x: dateArr,
        y: lightArr,
        type: 'scatter'
    }];

    return sortedArrays;
}

function makeCharts(data)
{
    //var humidityCtx = $('#humidity');
    //var humidityChart = new Chart(humidityCtx).Scatter(data, {});
    var humidityLayout = {
        xaxis: {
            title: 'Date Recorded',
            tickformat: "%y/%m/%d %I:%M %p",
            hoverformat: "%y/%m/%d %I:%M %p"
        },
        yaxis: {
            title: 'Humidity (%)'
        }
    };

    var temperatureLayout = {
        xaxis: {
            title: 'Date Recorded',
            tickformat: "%y/%m/%d %I:%M %p",
            hoverformat: "%y/%m/%d %I:%M %p"
        },
        yaxis: {
            title: 'Temperatrue (F)'
        }
    };

    var lightLayout = {
        xaxis: {
            title: 'Date Recorded',
            tickformat: "%y/%m/%d %I:%M %p",
            hoverformat: "%y/%m/%d %I:%M %p"
        },
        yaxis: {
            title: 'Light (lux)'
        }
    };

    Plotly.newPlot('humidity', data.humidityData, humidityLayout);
    Plotly.newPlot('temperature', data.temperatureData, temperatureLayout);
    Plotly.newPlot('light', data.lightData, lightLayout);
}

