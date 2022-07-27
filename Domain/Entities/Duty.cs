using Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Duty
    {
        [Key]
        public int Id { get; set; }        
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime RequiredBy { get; set; }
        public string Description { get; set; }
        public DutyStatus Status { get; set; }
        public DutyType Type { get; set; }
        public UserList AssignedTo { get; set; }
        public DateTime? NextActionDate { get; set; }


        public ICollection<Comment> Comments { get; set; }
    }
}
