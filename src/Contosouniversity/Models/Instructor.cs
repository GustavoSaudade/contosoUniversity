using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ContosoUniversity.Models
{
    public class Instructor
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Sobrenome")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Column("FirstName")]
        [Display(Name = "Nome")]
        [StringLength(50)]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de contratação")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Nome completo")]
        public string FullName
        {
            get { return LastName + ", " + FirstMidName; }
        }
        public ICollection<CourseAssignment> Courses { get; set; }

        public OfficeAssignment OfficeAssignment { get; set; }
    }
}