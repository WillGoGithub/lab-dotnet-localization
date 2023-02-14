using System.ComponentModel.DataAnnotations;

namespace Localization
{
    public class WeatherForecast
    {
        [Display(Name = "�ϰ�W��")]
        [Required(ErrorMessage = "REQUIRED_INPUT")]
        //[Required(ErrorMessage = "�п�J{0}")]
        [MaxLength(100, ErrorMessage = "{0}���פ��i�W�L {1} �X")]
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}