using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace firstApp.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentName", TypeName ="varchar(100)")]
        public string Name { get; set; }
        [Column("StudentGender", TypeName = "varchar(20)")]
        public string Gender { get; set; }
        public string Age { get; set; }

    }
}
