using System.ComponentModel.DataAnnotations;

namespace High_School_Application.Models
{
    public class Teachers
    {
        [Key]
        public int teacherId { get; set; }
        [Required, Display(Name ="Full Name/s")]
        public string Full_Names { get; set; }
        [Required, Display(Name ="Date of Birth")]
        public string DoB { get; set; }
        [Required, Display(Name ="Birth ID Number"), Range(typeof(int), "1", "13")]
        public string B_ID { get; set; }
        [Required, Display(Name ="Email Address")]
        public string Email { get; set; }
        [Required, Display(Name ="Home Address")]
        public string Home { get; set; }
        [Required, Display(Name ="Mobile number")]
        public string mobile { get; set; }
        [Required, Display(Name ="Gender")]
        public string Gender { get; set; }
        [Required, Display(Name ="Nationality")]
        public string Nationality { get; set; }
        public string Passport { get; set; }
        [Required, Display(Name ="Date Started")]
        public string D_started { get; set; }
    }
}
