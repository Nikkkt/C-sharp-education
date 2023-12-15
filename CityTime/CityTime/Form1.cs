using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TimeZoneConverter;
using NodaTime;

namespace CityTime
{
    public partial class Form1 : Form
    {
        private const string timezoneDbApiKey = "N4JGH2CMVROB";
        public Form1()
        {
            InitializeComponent();
        }
        // textBoxCity

        private async void btnGetTime_Click(object sender, EventArgs e)
        {
            string cityName = textBoxCity.Text;
            if (!string.IsNullOrEmpty(cityName))
            {
                try
                {
                    string timeZone = await GetTimeZone(cityName);
                    if (timeZone != null)
                    {
                        var time = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById(timeZone));
                        lblCurrentTime.Text = $"Current Time in {cityName}: {time}";
                    }
                    else
                    {
                        MessageBox.Show("Invalid city name or time zone.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a city name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> GetTimeZone(string cityName)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"http://api.timezonedb.com/v2.1/get-time-zone?key={timezoneDbApiKey}&format=json&by=zone&zone={cityName}";
                string jsonResult = await client.GetStringAsync(apiUrl);
                TimezoneDbApiResponse response = JsonConvert.DeserializeObject<TimezoneDbApiResponse>(jsonResult);

                if (response.Status == "OK")
                {
                    return response.ZoneName;
                }
                else
                {
                    return null;
                }
            }
        }
    }

    public class TimezoneDbApiResponse
    {
        public string Status { get; set; }
        public string ZoneName { get; set; }
    }
}