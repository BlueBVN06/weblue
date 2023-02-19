using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Weblue1.Pages
{
    public class MinecraftModel : PageModel
    {
        private readonly ILogger<MinecraftModel> _logger;

		public MinecraftModel(ILogger<MinecraftModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        
        }
    }
}