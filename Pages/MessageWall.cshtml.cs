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
        public MessageWallModel(ILogger<MessageWallModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
