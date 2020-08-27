
using System.ComponentModel.DataAnnotations;


namespace MyChartASPnetMVC.Models
{
    public class UserData
    {
        public int UserDataId { get; set; }

        [RegularExpression(@"^\d$", ErrorMessage = "Only numbers needed")] 
        public int a { get; set; }
        [RegularExpression(@"^\d$", ErrorMessage = "Only numbers needed")] 
        public int b { get; set; }
        [RegularExpression(@"^\d$", ErrorMessage = "Only numbers needed")] 
        public int c { get; set; }
        [Required]
        [RegularExpression(@"^\d$", ErrorMessage = "Only numbers needed")]
        public float step { get; set; }
        [Required]
        [RegularExpression(@"^\d$", ErrorMessage = "Only numbers needed")]
        public int RangeFrom { get; set; }
        [Required]
        [RegularExpression(@"^\d$", ErrorMessage = "Only numbers needed")]
        public int RangeTo { get; set; }        

    }
}