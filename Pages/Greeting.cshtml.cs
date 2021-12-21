using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorMessageWallApp.Pages
{
    public class GreetingModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }
        
        [BindProperty]
        public string LastName { get; set; }
        
        [BindProperty]
        public string Greeting { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Greeting = $"Hi {FirstName} {LastName}";
            return Page();
        }
    }
}
