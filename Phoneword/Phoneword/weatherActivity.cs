using System;
using Android.App;
using Android.OS;
using Android.Widget;
using System.Threading.Tasks;
using System.IO;
using System.Json;
using System.Net;

namespace Phoneword
{
    [Activity(Label = "Clima")]
    class weatherActivity : Activity

    {
            protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.weather);
 

       
            EditText ciudad = FindViewById<EditText>(Resource.Id.Ciudad);
            Button button = FindViewById<Button>(Resource.Id.getWeatherButton);
            
            button.Click += async (sender, e) =>
            {
                string url = "http://api.apixu.com/v1/current.json?key=43dad43a410f428d86e133125171804&q=" + ciudad.Text;


      
                JsonValue json = await FetchWeatherAsync(url);
                ParseAndDisplay (json);
            };
        }
        
     
        private async Task<JsonValue> FetchWeatherAsync(string url)
        {

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";
           
           
      
            using (WebResponse response = await request.GetResponseAsync())
            {
               
                using (Stream stream = response.GetResponseStream())
                {
         
                    JsonValue jsonDoc = await Task.Run(() => JsonObject.Load(stream));
      
                    return jsonDoc;
                }
            }
        }

    
        private void ParseAndDisplay(JsonValue json)
        {
  
            TextView location = FindViewById<TextView>(Resource.Id.locationText);
            TextView temperature = FindViewById<TextView>(Resource.Id.tempText);
            TextView humidity = FindViewById<TextView>(Resource.Id.humidText);
            TextView pais = FindViewById<TextView>(Resource.Id.pais);
            
            JsonValue temperatura = json["current"];
            JsonValue weatherResults = json["location"];

            location.Text = weatherResults["name"];

            double temperaturaApi = temperatura["temp_c"];
            temperature.Text = temperaturaApi.ToString() + "ºC";


            
            double humidPercent = temperatura["humidity"];
            humidity.Text =humidPercent.ToString() + "%";
            
            pais.Text = weatherResults["country"];
        }
    

    }// class
}//phoneword

