using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Domain.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public int DutyId { get; set; }
        public Duty Duty { get; set; }
        public DateTime AddedDate { get; set; }
        public string CommentText { get; set; }
        public CommentType Type { get; set; }
        public DateTime? ReminderDate { get; set; }
    }
}
