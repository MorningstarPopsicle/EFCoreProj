using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Student")]
public class Student
    {
       [Key]
       [Required]
        public int Id {get; set;}

        public string FirstName {get; set;}
        public string LastName {get; set;}
        [MaxLength(20)]
        public string Email {get; set;}
        public int DepartmentId {get; set;}
        public Department Department {get; set;}
    }