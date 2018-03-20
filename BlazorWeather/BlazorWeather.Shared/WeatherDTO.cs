namespace BlazorWeather.Shared
{
    public class WeatherDTO
    {
        public string DayName { get; set; }
        public string DayNumber { get; set; }
        public string MonthName { get; set; }
        public string Location { get; set; }
        public double Degree { get; set; }
        public float WindSpeed { get; set; }
        public string Compass { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public string WeatherName { get; set; }
        public string WeatherDescription { get; set; }
        public WeatherDayDTO[] DailyWeather { get; set; } = new WeatherDayDTO[Constants.MAXIMUN_NUMBER_OF_DAYS];
    }
}
