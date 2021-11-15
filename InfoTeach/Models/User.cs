using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTeach.Models
{
    [Table("Users")]
    public class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage ="Please enter a username.")]
        [StringLength(20)]
        public string Username { get; set;}
        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(200)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a last name.")]
        [StringLength(200)]
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Student> Students { get; set; }
        
    }
}
