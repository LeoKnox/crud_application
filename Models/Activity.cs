using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigProject.Models
{
    public class Activities 
    {
        [Key]
        public int ActivityId {get; set;}
        [Required]
        [MinLength(2)]
        [Display(Name = "Activity")]
        public string MyActivity {get; set;}

        [Required]
        [Display(Name = "Time")]
        public DateTime Time {get; set;}
        
        [Required]
        [Display(Name="Date")]
        public DateTime Date {get; set;}

        [Required]
        [Display(Name="Duration")]
        public int Duration {get; set;}

        [Required]
        public string Length {get; set;}

        [Required]
        [MinLength(10)]
        [Display(Name = "Description")]
        public string Description {get; set;}

        [Required]
        public int Coordinator {get; set;}

        public List<Guest> Attendee {get; set;}
    }
}