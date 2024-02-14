using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WordVoyagerMVC.Models
{
    public class TagModel
    {
        [Key]
        public int TagId { get; set; }

        [Required]
        [MaxLength(100)]
        public string TagName { get; set; }
    }
}