using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace BuffPortal.UI.Pages
{
    [Authorize]
    public class SecuredModel : PageModel
    {
        private readonly ILogger<SecuredModel> _logger;

        public SecuredModel(ILogger<SecuredModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

