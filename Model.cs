namespace YourNameSpace.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class ContactFormModel
    {
        [Required(ErrorMessage = "Please provide your first name")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please provide your email")]
        [DisplayName("Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please write a message")]
        [DisplayName("Message")]
        public string Message { get; set; }
    }
}