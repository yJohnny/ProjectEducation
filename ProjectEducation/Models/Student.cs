using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEducation.Models
{
    public class Student
    {
        public int ID { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Укажите фамилию")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Укажите имя")]
        [StringLength(50)]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        [Required(ErrorMessage = "Укажите дату")]

        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public ICollection<Enrollment> Enrollments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(this.FirstMidName))
            {
                errors.Add(new ValidationResult("Введите имя!", new List<string>() { "Name" }));
            }

            if (string.IsNullOrWhiteSpace(this.LastName))
            {
                errors.Add(new ValidationResult("Введите фамилию!"));
            }

            return errors;
        }

    }
}
