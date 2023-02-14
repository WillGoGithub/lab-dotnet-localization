using System.ComponentModel.DataAnnotations;

namespace Localization
{
    public class WeatherForecast
    {
        [Display(Name = "區域名稱")]
        [Required(ErrorMessage = "REQUIRED_INPUT")]
        //[Required(ErrorMessage = "請輸入{0}")]
        [MaxLength(100, ErrorMessage = "{0}長度不可超過 {1} 碼")]
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}