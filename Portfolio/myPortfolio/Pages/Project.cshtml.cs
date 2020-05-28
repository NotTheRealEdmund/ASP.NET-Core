using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace myPortfolio.Pages
{
    public class ProjectModel : PageModel
    {
        private readonly ILogger<ProjectModel> _logger;

        public ProjectModel(ILogger<ProjectModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
