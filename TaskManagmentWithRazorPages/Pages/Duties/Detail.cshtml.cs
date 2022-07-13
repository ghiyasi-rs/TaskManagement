using Domain.Entities;
using Domain.Enums;
using Domain.Error;
using Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using NToastNotify;
using TaskManagmentWithRazorPages.Pages.Duties.ViewModels;

namespace TaskManagmentWithRazorPages.Pages.Duties
{
    public class DetailModel : PageModel
    {
        ICommentRepository _commentRepository;
        IDutyRepository _dutyRepository;
        public IList<Comment> _comments;
        public Duty _duty;
        public Comment _comment;
        private readonly IToastNotification _toastNotification;

        public DetailModel(ICommentRepository commentRepository, IDutyRepository dutyRepository, IToastNotification toastNotification)
        {
            _commentRepository = commentRepository;
            _dutyRepository = dutyRepository;
            _toastNotification = toastNotification;

        }

        public async Task OnGet(int dutyId)
        {
            _duty = await _dutyRepository.GetByIdAsync(dutyId);
            _comments = await _commentRepository.GetAllByIdAsync(dutyId);


        }

        public PartialViewResult OnGetAddCommentPartial(int dutyId)
        {
            VMComment vmComment = new VMComment()
            {
                DutyId = dutyId
            };

            return new PartialViewResult
            {
                ViewName = "_AddComment",
                ViewData = new ViewDataDictionary<VMComment>(ViewData, vmComment)
            };
        }
        public async Task<IActionResult> OnPostAddComment(VMComment vmComment)
        {
             ServiceResult<bool> result;
            if (vmComment != null && ! string.IsNullOrEmpty(vmComment.CommentText))
            {
                Comment comment = new Comment()
                {

                    DutyId = vmComment.DutyId,
                    CommentText = vmComment.CommentText,
                    AddedDate = DateTime.Now,
                    ReminderDate = vmComment.ReminderDate,
                    Type = (CommentType)vmComment.Type,


                };
                if (vmComment.Id != 0)
                {
                    comment.Id = vmComment.Id;
                     result = await _commentRepository.UpdateAsync(comment);
                }

                else
                     result = await _commentRepository.AddAsync(comment);


              
                if (result.Result)
                    _toastNotification.AddSuccessToastMessage("Comment created successful!");
                

                  if (vmComment.ReminderDate != null)
                {
                    var duty = await _dutyRepository.GetByIdAsync(vmComment.DutyId);
                    duty.NextActionDate =(DateTime) vmComment.ReminderDate ;
                    await _dutyRepository.UpdateAsync(duty);

                }  

            }

         else
                _toastNotification.AddErrorToastMessage("Comment created failed! Command Text cann't be empty");

            return RedirectToPage(new { dutyId = vmComment.DutyId });
        }
        public async Task<PartialViewResult> OnGetUpdateCommentPartial(int Id)
        {
            var comment = await _commentRepository.GetByIdAsync(Id);

            VMComment vmComment = new VMComment()
            {
                Id = comment.Id,
                AddedDate = comment.AddedDate,
                ReminderDate = comment.ReminderDate,
                CommentText = comment.CommentText,
                DutyId = comment.DutyId,
                Type = (int)comment.Type
            };
            return new PartialViewResult
            {
                ViewName = "_AddComment",
                ViewData = new ViewDataDictionary<VMComment>(ViewData, vmComment)
            };
        }
        public async Task<IActionResult> OnGetDeleteComment(int Id, int dutyId)
        {
          var result=  await _commentRepository.DeleteAsync(Id);
            if (result.Result)
                _toastNotification.AddSuccessToastMessage("Comment deleted successful!");
            else

                _toastNotification.AddErrorToastMessage("Comment deleted failed!");
            return RedirectToPage(new { dutyId = dutyId });
        }
        public async Task<JsonResult> OnGetSearch(string searchText, int dutyId)
        {
            Dictionary<string, string> commentsList = new Dictionary<string, string>();
            var comments = await _commentRepository.GetAllBySearchTextAsync(searchText, dutyId);

            foreach (var comment in comments)
            {
                commentsList.Add(comment.Id.ToString(), comment.CommentText);
            }
            return new JsonResult(commentsList);

        }


    }
}
