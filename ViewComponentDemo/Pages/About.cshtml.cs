using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ViewComponentDemo.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; private set; }

        public void OnGet()
        {
            Message = "Your application description page.";
        }
    }
}
