using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Project_V1.Weather
{
    public class WeatherClass
    {
        public async static Task<RootObject> GetWeather(double lat, double lon)
        {
            var http = new HttpClient();

            var apiurl = String.Format("https://api.apixu.com/v1/forecast.json?key=9038eee216524157bfb235747181807&q={0},{1}&days=7"
                , lat.ToString(), lon.ToString());
            var response = await http.GetAsync(apiurl);
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);

            return data;

        }
    }

    [DataContract]
    public class Location
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string region { get; set; }
        [DataMember]
        public string country { get; set; }
        [DataMember]
        public double lat { get; set; }
        [DataMember]
        public double lon { get; set; }
        [DataMember]
        public string tz_id { get; set; }
        [DataMember]
        public int localtime_epoch { get; set; }
        [DataMember]
        public string localtime { get; set; }
    }
    [DataContract]
    public class Condition
    {
        [DataMember]
        public string text { get; set; }
        [DataMember]
        public string icon { get; set; }
        [DataMember]
        public int code { get; set; }
    }
    [DataContract]
    public class Current
    {
        [DataMember]
        public int last_updated_epoch { get; set; }
        [DataMember]
        public string last_updated { get; set; }
        [DataMember]
        public double temp_c { get; set; }
        [DataMember]
        public double temp_f { get; set; }
        [DataMember]
        public int is_day { get; set; }
        [DataMember]
        public Condition condition { get; set; }
        [DataMember]
        public double wind_mph { get; set; }
        [DataMember]
        public double wind_kph { get; set; }
        [DataMember]
        public int wind_degree { get; set; }
        [DataMember]
        public string wind_dir { get; set; }
        [DataMember]
        public double pressure_mb { get; set; }
        [DataMember]
        public double pressure_in { get; set; }
        [DataMember]
        public double precip_mm { get; set; }
        [DataMember]
        public double precip_in { get; set; }
        [DataMember]
        public int humidity { get; set; }
        [DataMember]
        public int cloud { get; set; }
        [DataMember]
        public double feelslike_c { get; set; }
        [DataMember]
        public double feelslike_f { get; set; }
        [DataMember]
        public double vis_km { get; set; }
        [DataMember]
        public double vis_miles { get; set; }
    }
    [DataContract]
    public class Condition2
    {
        [DataMember]
        public string text { get; set; }
        [DataMember]
        public string icon { get; set; }
        [DataMember]
        public int code { get; set; }
    }
    [DataContract]
    public class Day
    {
        [DataMember]
        public double maxtemp_c { get; set; }
        [DataMember]
        public double maxtemp_f { get; set; }
        [DataMember]
        public double mintemp_c { get; set; }
        [DataMember]
        public double mintemp_f { get; set; }
        [DataMember]
        public double avgtemp_c { get; set; }
        [DataMember]
        public double avgtemp_f { get; set; }
        [DataMember]
        public double maxwind_mph { get; set; }
        [DataMember]
        public double maxwind_kph { get; set; }
        [DataMember]
        public double totalprecip_mm { get; set; }
        [DataMember]
        public double totalprecip_in { get; set; }
        [DataMember]
        public double avgvis_km { get; set; }
        [DataMember]
        public double avgvis_miles { get; set; }
        [DataMember]
        public double avghumidity { get; set; }
        [DataMember]
        public Condition2 condition { get; set; }
        [DataMember]
        public double uv { get; set; }
    }
    [DataContract]
    public class Astro
    {
        [DataMember]
        public string sunrise { get; set; }
        [DataMember]
        public string sunset { get; set; }
        [DataMember]
        public string moonrise { get; set; }
        [DataMember]
        public string moonset { get; set; }
    }
    [DataContract]
    public class Forecastday
    {
        [DataMember]
        public string date { get; set; }
        [DataMember]
        public int date_epoch { get; set; }
        [DataMember]
        public Day day { get; set; }
        [DataMember]
        public Astro astro { get; set; }
    }
    [DataContract]
    public class Forecast
    {
        [DataMember]
        public List<Forecastday> forecastday { get; set; }
    }
    [DataContract]
    public class RootObject
    {
        [DataMember]
        public Location location { get; set; }
        [DataMember]
        public Current current { get; set; }
        [DataMember]
        public Forecast forecast { get; set; }
    }
}
