using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using System.Net;
using System.Json;
using System;
using System.IO;

namespace Weather
{
    [Activity(Label = "Weather", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get the latitude/longitude EditBox and button resources:
            EditText ciudad = FindViewById<EditText>(Resource.Id.ciudad);
            Button button = FindViewById<Button>(Resource.Id.getWeatherButton);

            // When the user clicks the button ...
            button.Click += async (sender, e) =>
            {
                string url = "http://api.apixu.com/v1/current.json?key=43dad43a410f428d86e133125171804&q=" + ciudad.Text;
               

                // Fetch the weather information asynchronously, 
                // parse the results, then update the screen:
                JsonValue json = await FetchWeatherAsync(url);
                // ParseAndDisplay (json);
            };
        }

        // Gets weather data from the passed URL.
        private async Task<JsonValue> FetchWeatherAsync(string url)
        {
            // Create an HTTP web request using the URL:
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            // Send the request to the server and wait for the response:
            using (WebResponse response = await request.GetResponseAsync())
            {
                // Get a stream representation of the HTTP web response:
                using (Stream stream = response.GetResponseStream())
                {
                    // Use this stream to build a JSON document object:
                    JsonValue jsonDoc = await Task.Run(() => JsonObject.Load(stream));
                    Console.Out.WriteLine("Response: {0}", jsonDoc.ToString());

                    // Return the JSON document:
                    return jsonDoc;
                }
            }
        }

        // Parse the weather data, then write temperature, humidity, 
        // conditions, and location to the screen.
        private void ParseAndDisplay(JsonValue json)
        {
            // Get the weather reporting fields from the layout resource:
            TextView location = FindViewById<TextView>(Resource.Id.locationText);
            TextView temperature = FindViewById<TextView>(Resource.Id.tempText);
            TextView humidity = FindViewById<TextView>(Resource.Id.humidText);
            TextView conditions = FindViewById<TextView>(Resource.Id.condText);

            // Extract the array of name/value results for the field name "weatherObservation". 
            JsonValue weatherResults = json["Location"];

            // Extract the "stationName" (location string) and write it to the location TextBox:
            location.Text = weatherResults["name"];

            temperature.Text = weatherResults["temp_c"];

            // Get the percent humidity and write it to the humidity TextBox:
            double humidPercent = weatherResults["humidity"];
            humidity.Text = humidPercent.ToString() + "%";
            // Write the result to the conditions TextBox:
            conditions.Text = weatherResults["condition"];
        }

    }

    }


