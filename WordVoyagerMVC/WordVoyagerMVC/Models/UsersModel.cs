using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WordVoyagerMVC.Models
{
    public class UsersModel
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [MaxLength(100)]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [MaxLength(12)]
        public string PasswordHash { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }


    }
}