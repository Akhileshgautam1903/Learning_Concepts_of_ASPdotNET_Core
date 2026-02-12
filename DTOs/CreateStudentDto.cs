using System.ComponentModel.DataAnnotations;

namespace Learning_Concepts_of_ASPdotNET_Core.DTOs
{
    public class CreateStudentDto
    {
        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

    }
}
