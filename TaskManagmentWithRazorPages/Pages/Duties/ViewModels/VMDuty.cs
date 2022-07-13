using Domain.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace TaskManagmentWithRazorPages.Pages.Duties.ViewModels
{
    public class VMDuty
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now.Date;
        public DateTime RequiredBy { get; set; } = DateTime.Now.Date;
        [Required]
        public int Status { get; set; }
        [Required]
        public int Type { get; set; }
        [Required]
        public UserList AssignedTo { get; set; }

        public DateTime? NextActionDate { get; set; } 
    }
}
