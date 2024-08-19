using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebTarefa.Pages
{
    public class CarroselModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public CarroselModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
