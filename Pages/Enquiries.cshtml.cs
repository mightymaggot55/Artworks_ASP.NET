﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Artworks_ASP.NET.ConnectionManager;


namespace Artworks_ASP.NET.Pages
{
    public class EnquiryModel : PageModel
    {
        private readonly ILogger<EnquiryModel> _logger;

        public EnquiryModel(ILogger<EnquiryModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}