using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BigProject.Models
{
    public class User
    {
       [Key]
       public int UserId {get; set;}
       [Required]
       [MinLength(2)]
       [Display(Name = "First Name")]
       public string FirstName {get; set;}
       [Required]
       [MinLength(2)]
       [Display(Name = "Last Name")]
       public string LastName {get; set;}
       [Required]
       [EmailAddress]
       [Display(Name = "Email Address")]
       public string Email {get; set;}
       [DataType(DataType.Password)]
       [Required]
       [RegularExpression("^([a-zA-Z]{1,})([@$!%*#?&]{1,})([0-9]{1,})$", ErrorMessage="Must contain a # or special character")]
       [MinLength(8, ErrorMessage=" Must be at least 8 characters")]
       public string Password{get; set;}

       [NotMapped]
       [Compare("Password")]
       [Display(Name = "Confirm Password")]
       [DataType(DataType.Password)]
       public string cPassword {get; set;}
       
       public DateTime CreatedAt {get;set;}
       public DateTime UpdatedAt {get;set;}

        public List<Guest> Attending {get; set;}
    }
}