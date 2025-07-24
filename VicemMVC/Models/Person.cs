using System.ComponentModel.DataAnnotations;

namespace VicemMVC.Models
{
    public class Person
    {
        [Key]
        public string PersonID { get; set; } = default!;
        public string FullName { get; set; } = default!;
        public int Age { get; set; } = default!;
    }
}