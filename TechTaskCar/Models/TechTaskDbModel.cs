using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechTaskCar.Models
{
    public class Submission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubmissionId { get; set; }

       
        public string TopicList { get; set; }


 
        [MaxLength(50)]
        public string FirstName { get; set; }

 
        [MaxLength(50)]
        public string LastName { get; set; }

       
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Company { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        public string Questions { get; set; }
    } 
}
