using System;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool IsCompleted { get; set; }

        [Required]
        [Display(Name="Due Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DueDate { get; set; }

        public DateTime CompletedDate { get; set; }
    }
}