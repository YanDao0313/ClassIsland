﻿using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text.Json.Serialization;

namespace ClassIsland.Models.Weather;

public class WeatherInfo
{

    [JsonPropertyName("current")] public CurrentWeather Current { get; set; } = new();

    [JsonPropertyName("alerts")] public List<WeatherAlert> Alerts { get; set; } = new();


    [JsonPropertyName("updateTime")] public int UpdateTimeUnix { get; set; } = 0;

    [JsonIgnore] public DateTime UpdateTime => new DateTime(UpdateTimeUnix);
}