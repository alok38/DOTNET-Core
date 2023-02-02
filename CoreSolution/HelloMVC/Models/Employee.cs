
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace HelloMVC.Models
    {
        public class Employee
        {
            [Key]
            public int Id { get; set; }
            [Required]
            [Column(TypeName = "varchar(10)")]
            public string Name { get; set; }
            public decimal Salary { get; set; }
        }
    }

