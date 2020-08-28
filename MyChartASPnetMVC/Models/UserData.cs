
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MyChartASPnetMVC.Models
{
    public class UserData
    {
        //[HiddenInput(DisplayValue = false)] 
        public int UserDataId { get; set; }
                
        public int a { get; set; }
                
        public int b { get; set; }
                
        public int c { get; set; }

        [Required(ErrorMessage = "The field is required")]        
        //[RegularExpression(@"^\d$", ErrorMessage = "Only numbers needed")]
        public float step { get; set; }

        [Required(ErrorMessage = "The field is required")]        
        public int RangeFrom { get; set; }

        [Required(ErrorMessage = "The field is required")]        
        public int RangeTo { get; set; }        

    }
}