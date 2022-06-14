using Newtonsoft.Json.Converters;
using TP2.Deserialized_Classes;

namespace TP2
{
    class Program
    {
        static async Task Main()
        {
            // Question 1
            Root questions1 = await Http.Retrieve("https://api.openweathermap.org/data/2.5/weather?q=Kingdom of Morocco&units=metric&appid=248c99acfb90ee02a608610eff59ca6e");
            Console.WriteLine("The weather in Morocco is : " + questions1.weather[0].description + "\n");
            
            // Question 2
            Root questions2 = await Http.Retrieve("https://api.openweathermap.org/data/2.5/weather?q=Oslo&units=metric&appid=248c99acfb90ee02a608610eff59ca6e");
            long sunrise = questions2.sys.sunrise + 7200;
            long sunset = questions2.sys.sunset + 7200;
            Console.WriteLine("The sunrise at Oslo is at : " + DateTime.UnixEpoch.AddSeconds(sunrise));
            Console.WriteLine("The sunset at Oslo is at : " + DateTime.UnixEpoch.AddSeconds(sunset) + "\n");
            
            // Question 3
            Root questions3 = await Http.Retrieve("https://api.openweathermap.org/data/2.5/weather?q=Jakarta&units=metric&appid=248c99acfb90ee02a608610eff59ca6e");
            Console.WriteLine("The temperature in Jakarta is at: " + questions3.main.temp + "°C \n");
            
            // Question 4
            Root questions41 = await Http.Retrieve("https://api.openweathermap.org/data/2.5/weather?q=New York City&units=metric&appid=248c99acfb90ee02a608610eff59ca6e");
            Console.WriteLine("The speed of the wind in New York is at : " + questions41.wind.speed + " m/s");
            Root questions42 = await Http.Retrieve("https://api.openweathermap.org/data/2.5/weather?q=Tokyo&units=metric&appid=248c99acfb90ee02a608610eff59ca6e");
            Console.WriteLine("The speed of the wind in Tokyo is at : " + questions42.wind.speed + " m/s");
            Root questions43 = await Http.Retrieve("https://api.openweathermap.org/data/2.5/weather?q=Paris&units=metric&appid=248c99acfb90ee02a608610eff59ca6e");
            Console.WriteLine("The speed of the wind in Paris is at : " + questions43.wind.speed + " m/s");
            if (questions41.wind.speed > questions42.wind.speed & questions41.wind.speed > questions43.wind.speed)
            {
                Console.WriteLine(("It is more windy in New York \n"));
            }
            else if (questions42.wind.speed > questions41.wind.speed & questions42.wind.speed > questions43.wind.speed)
            {
                Console.WriteLine(("It is more windy in Tokyo \n"));
            }
            else
            {
                Console.WriteLine(("It is more windy in Paris \n"));
            }
            
            // Question 5
            Root questions51 = await Http.Retrieve("https://api.openweathermap.org/data/2.5/weather?q=Kiev&units=metric&appid=248c99acfb90ee02a608610eff59ca6e");
            Console.WriteLine("The humidity in Kiev is at: " + questions51.main.humidity + "% and the pressure is at: " + questions51.main.pressure + " hPa");
            Root questions52 = await Http.Retrieve("https://api.openweathermap.org/data/2.5/weather?q=Moscow&units=metric&appid=248c99acfb90ee02a608610eff59ca6e");
            Console.WriteLine("The humidity in Moscow is at: " + questions52.main.humidity + "% and the pressure is at: " + questions52.main.pressure + " hPa");
            Root questions53 = await Http.Retrieve("https://api.openweathermap.org/data/2.5/weather?q=Berlin&units=metric&appid=248c99acfb90ee02a608610eff59ca6e");
            Console.WriteLine("The humidity in Berlin is at: " + questions53.main.humidity + "% and the pressure is at: " + questions53.main.pressure + " hPa");
        }
    }
}