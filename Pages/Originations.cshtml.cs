using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Artworks_ASP.NET.Pages
{
    public class OriginationModel : PageModel
    {
        private readonly ILogger<OriginationModel> _logger;

        public OriginationModel(ILogger<OriginationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}