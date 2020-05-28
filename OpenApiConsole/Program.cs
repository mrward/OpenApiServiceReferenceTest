using System;
using System.Threading.Tasks;

namespace OpenApiConsole
{
	class Program
	{
		static void Main (string[] args)
		{
			try {
				Run ().Wait ();
			} catch (Exception ex) {
				Console.WriteLine (ex);
			}
		}

		static async Task Run ()
		{
			var client = new swaggerClient ("https://localhost:5001/", new System.Net.Http.HttpClient ());
			var forecasts = await client.WeatherForecastAsync ();
			foreach (var forecast in forecasts) {
				Console.WriteLine (forecast.Summary);
			}
		}
	}
}
