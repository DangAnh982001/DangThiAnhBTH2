using System.ComponentModel.DataAnnotations;
namespace DangThiAnhBTH2.Models
{
    public class Student
    {
        [Key]
        public string? StdID { get; set; }
        public string? StdName { get; set; }
        public string? Address { get; set; }
    }
}