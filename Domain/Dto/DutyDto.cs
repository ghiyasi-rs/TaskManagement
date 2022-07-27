using Domain.Enums;
using Domain.Entities;


namespace Domain.Dto
{
    public class DutyDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime RequiredBy { get; set; }
        public string Description { get; set; }
        public DutyStatus Status { get; set; }
        public DutyType Type { get; set; }
        //public List<string> AssignedTo { get; set; }
        public DateTime NextActionDate { get; set; }
        //public List<Comment> Comments { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
