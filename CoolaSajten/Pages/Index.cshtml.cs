using CoolaSajten.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoolaSajten.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public DateTime  Nu { get; set; }
        public List<HockeyPlayer> AllPlayers { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var service = new HockeyService();
            AllPlayers = service.GetAllPlayers();
            Nu = DateTime.Now;
        }
    }
}