using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace High_School_Application.Models.Grades
{
    public class Grade_Nine
    {
        [Key]
        public int LearnerId { get; set; }
        [ForeignKey("ParentId")]
        public int ParentId { get; set; }
        public virtual Parents_Guardian Parents_Guardian { get; set; }
        [Required, Display(Name = "Full Name/s")]
        public string Full_Names { get; set; }
        [Required, Display(Name = "Date of Birth")]
        public string DoB { get; set; }
        [Required, Display(Name = "Birth ID Number"), Range(typeof(int), "1", "13")]
        public string B_ID { get; set; }
        [Required, Display(Name = "Home Address")]
        public string Home { get; set; }
        [Required, Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required, Display(Name = "Nationality")]
        public string Nationality { get; set; }
        public string Passport { get; set; }
        public string image { get; set; }
    }
}
