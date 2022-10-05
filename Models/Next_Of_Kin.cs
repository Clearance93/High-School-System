using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace High_School_Application.Models
{
    public class Next_Of_Kin
    {
        [Key]
        public int Next_Of_KinId { get; set; }
        [Required, Display(Name = "Full Name/s")]
        public string Full_Names { get; set; }
        [Required, Display(Name = "Date of Birth")]
        public string DoB { get; set; }
        [Required, Display(Name = "Birth ID Number"), Range(typeof(int), "1", "13")]
        public string B_ID { get; set; }
        [Required, Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required, Display(Name = "Home Address")]
        public string Home { get; set; }
        [Required, Display(Name = "Mobile number")]
        public string mobile { get; set; }
        [Required, Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required, Display(Name = "Nationality")]
        public string Nationality { get; set; }
        public string Passport { get; set; }
        [Required, Display(Name = "relationship to the child")]
        public string relationship { get; set; }
        [Required, Display(Name = "Marriage status")]
        public string marriage { get; set; }
        [Required, Display(Name = "Work Status")]
        public string work { get; set; }
        [Display(Name = "Name of the company")]
        public string company { get; set; }
        [Display(Name = "Company number")]
        public string company_number { get; set; }
        public string position { get; set; }
        [Display(Name = "Work Email")]
        public string work_email { get; set; }
        [Display(Name = "Spouse Name")]
        public string spouse { get; set; }
        public string image { get; set; }
    }
}
