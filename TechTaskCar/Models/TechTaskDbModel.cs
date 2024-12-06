
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubmissionId { get; set; }

        [Required(ErrorMessage = "Please select a topic.")]
        public required string TopicList { get; set; }

        [Required(ErrorMessage = "Required.")]
        [MaxLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public required string FirstName { get; set; }

        [Required(ErrorMessage = "Required.")]
        [MaxLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public required string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [MaxLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public required string Email { get; set; }

        [MaxLength(50, ErrorMessage = "Company name cannot exceed 50 characters.")]
        public string? Company { get; set; }

        [MaxLength(50, ErrorMessage = "Title cannot exceed 50 characters.")]
        public string? Title { get; set; }

        public string? Questions { get; set; }
    }

}
