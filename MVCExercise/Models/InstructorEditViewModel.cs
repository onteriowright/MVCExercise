using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExercise.Models
{
    public class InstructorEditViewModel
    {
        public int InstructorId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [MinLength(3)]
        public string LastName { get; set; }

        [Display(Name = "Cohort")]
        public int CohortId { get; set; }

        [Display(Name = "Slack Handle")]
        public string SlackHandle { get; set; }
        public string Specialty { get; set; }
        public List<SelectListItem> CohortOptions { get; set; }
    }
}
