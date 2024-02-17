using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EncryptionAndDecryption.Models
{
    public class Alphabet
    {
        [HiddenInput]
        public int AlphabetId { get; set; }

        [Required(ErrorMessage = "Please provide the name of the alphabet!")]
        public string AlphabetName { get; set; }

        [Required(ErrorMessage = "Please provide any chars for the alphabet!")]
        public string AlphabetChars { get; set; }
    }
}
