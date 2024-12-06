
//using some core packages to be able add some form restictions
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


//using the modals as name space to aid with cross file connectivity, scalebility and readablity =
namespace TechTaskCar.Models
{

    //calling submission from our previous model "TechTaskDbContent" to fill with properties
    public class Submission
    {

        //creating a unique identifier for each submission of the form
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubmissionId { get; set; }

       [Required]
        public string TopicList { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
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
