using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorMessageWallApp.Pages
{
    public class MessageWallModel : PageModel
    {
        private readonly ILogger<MessageWallModel> _logger;
        [BindProperty] //Mean that you can post to this
        public string Message { get; set; }

        [BindProperty]
        public List<string> Messages { get; set; } = new List<string>();
        public MessageWallModel(ILogger<MessageWallModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            Messages.Add(Message);
            return Page();
        }
    }
}
