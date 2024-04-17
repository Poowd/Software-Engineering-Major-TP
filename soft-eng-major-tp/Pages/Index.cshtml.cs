using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace soft_eng_major_tp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public String img1 = "https://www.minecraft.net/content/dam/games/minecraft/key-art/Vanilla-PMP_Collection-Carousel-0_Update-Aquatic_1280x768.jpg";
        public String img2 = "https://pbs.twimg.com/media/FTsV3NLWQAEFfXJ?format=jpg&name=large";
        public String img3 = "https://www.minecraft.net/content/dam/games/minecraft/key-art/Vanilla-PMP_Collection-Carousel-0_Caves-and-Cliffs_1280x768.jpg";

        public void OnGet()
        {

        }
    }
}