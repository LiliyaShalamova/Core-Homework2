using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreHomework2.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "Укажите имя")]
        [MaxLength(15)]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Укажите фамилию")]
        [MaxLength(15)]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Укажите группу")]
        [MaxLength(15)]
        [Display(Name = "Группа")]
        public string Group { get; set; }

        public string University { get; set; }
    }
}
