using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace soft_eng_major_tp.Pages.Public
{
    public class EventsModel : PageModel
    {
        public String img1 = "https://www.noypigeeks.com/wp-content/uploads/2023/08/VCT-2024-Season.jpg";
        public String img2 = "https://egamersworld.com/_next/image?url=https%3A%2F%2Fegamersworld.com%2Fuploads%2Fblog%2F1699471085739.jpg&w=1920&q=75";
        public String img3 = "https://images.contentstack.io/v3/assets/bltad9188aa9a70543a/blte3fbbac9fb76cbbc/657b3cb369408331834d248f/ss24-articleheader-1600x900.jpg?width=3200&height=1800";

        public void OnGet()
        {
        }
    }
}
