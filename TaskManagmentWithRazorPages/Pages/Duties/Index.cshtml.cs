using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using NToastNotify;
using TaskManagmentWithRazorPages.Pages.Duties.ViewModels;

namespace TaskManagmentWithRazorPages.Pages.Duties
{
    public class IndexModel : PageModel
    {
        IDutyRepository _dutyRepository;
        public IList<Duty> _duties;
        private readonly IToastNotification _toastNotification;

        public IndexModel(IDutyRepository dutyRepository, IToastNotification toastNotification)
        {
            _dutyRepository = dutyRepository;
            _toastNotification = toastNotification;
        }

        public async Task OnGetAsync()
        {
            _duties = await _dutyRepository.GetAllAsync();

        }

        public PartialViewResult OnGetAddDutyPartial()
        {
            VMDuty vmduty = new VMDuty();

            return new PartialViewResult
            {
                ViewName = "_AddDuty",
                ViewData = new ViewDataDictionary<VMDuty>(ViewData, vmduty)
            };
        }

        public async Task<IActionResult> OnPostAddDuty(VMDuty vmduty)
        {
            if (ModelState.IsValid)
            {
               
                    Duty NewDuty = new Duty()
                    {
                        Title = vmduty.Title,
                        Description = vmduty.Description,
                        CreatedDate = DateTime.Now,
                        RequiredBy = vmduty.RequiredBy,
                        Type = (DutyType)vmduty.Type,
                        Status = (DutyStatus)vmduty.Status,
                        AssignedTo = (UserList)vmduty.AssignedTo,

                    };

                    var result = await _dutyRepository.AddAsync(NewDuty);
                    if (result.Result)
                        _toastNotification.AddSuccessToastMessage("Task created successful!");
                
            }
            else
                _toastNotification.AddErrorToastMessage("Task created failed! ");
            return RedirectToPage();
        }

        public async Task<IActionResult> OnGetDeleteTask(int Id)
        {
            var result = await _dutyRepository.DeleteAsync(Id);
            if (result.Result)
                _toastNotification.AddSuccessToastMessage("Task deleted successful!");
            else

                _toastNotification.AddErrorToastMessage("Task deleted failed!");

            return RedirectToPage();
        }
    }
}
