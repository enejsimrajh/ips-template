using System.ComponentModel.DataAnnotations;
using Core.DAL.Infrastructure;

namespace IPSTemplate.Dal.Models
{
    public class TEAuthor : Entity
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string Country { get; set; }

        public int BirthYear { get; set; }
    }
}
