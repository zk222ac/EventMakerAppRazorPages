using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_EventMaker.Models;

namespace RazorPages_EventMaker.Pages.Events
{
    public class CreateEventsModel : PageModel
    {
        private FakeEventRepository repo;

        [BindProperty]
        public Event Event { get; set; }

        public CreateEventsModel()
        {
            repo = FakeEventRepository.Instance;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {       
            if(!ModelState.IsValid)
            {
                return Page();
            }
            repo.AddEvents(Event);
            // retuen to Main Index Page .....S
            return RedirectToPage("Index");
        }
    }
}
