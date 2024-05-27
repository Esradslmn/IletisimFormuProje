using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MyContacts.Models
{
    public class Contact
    {
        //Contact Tabel'ın Primary Keyi
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a first name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Please enter a last name")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Please enter a phone number")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Please enter an email")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Please select a department")]
        //Category Tabel'ın Foreign Keyi
        public int? CategoryId { get; set; }

        //Navigation property
        [ValidateNever]
        public Category Category { get; set; } = null!;

        [Required(ErrorMessage = "Please enter an message")]
        public string Message { get; set; } = null!;

        public DateTime DateAdded { get; set; }

        //Kişinin tam adını döndürebilmek için
        public string Slug => FirstName?.Replace(' ', '-').ToLower() + '-' + LastName?.Replace(' ', '-').ToLower();
    }
}