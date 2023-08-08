using System.ComponentModel.DataAnnotations;

namespace Laboratory.Models
{
    public class Request
    {
        public int Id { get; set; }

        [Range(1000000000, 9999999999, ErrorMessage = "InValid")]
        public int NationalOrResidenceId { get; set; }

        public int UniversityNumber { get; set; }

        public string StudentsStatus { get; set; }

        public string College { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "InValid, Must be between {1} and {2} number")]
        public string FirstNameEnglish { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "InValid, Must be between {1} and {2} number")]
        public string FatherNameEnglish { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "InValid")]
        public string GrandFatherNameEnglish { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "InValid, Must be between {1} and {2} number")]
        public string FamilyNameEnglish { get; set; }

        public string FirstNameArabic { get; set; }

        public string FatherNameArabic { get; set; }

        public string GrandFatherNameArabic { get; set; }

        public string FamilyNameArabic { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(05)+[0-9]{8}")]
        public String PhoneNo { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public int? MedicalFileNo { get; set; }

        [DataType(DataType.Date)]
        public DateTime TestDate { get; set; }
        public string? NationalOrResidenceIdFile { get; set; }
        public string? CopyOfStudentId { get; set; }
    }
}
