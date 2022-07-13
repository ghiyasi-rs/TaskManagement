using System.ComponentModel.DataAnnotations;

namespace TaskManagmentWithRazorPages.Pages.Duties.ViewModels
{
    public class VMComment
    {
        public int Id { get; set; }
        public int DutyId { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now.Date;
        [Required]
        public string CommentText { get; set; }
        [Required]
        public int Type { get; set; }
        public DateTime? ReminderDate { get; set; } = DateTime.Now.Date;
    }
  
}
