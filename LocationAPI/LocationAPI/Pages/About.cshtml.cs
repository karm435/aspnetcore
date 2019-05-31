using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace LocationAPI.Pages
{
    public class AboutModel : PageModel
    {
        private readonly IConfiguration _config;
        public AboutModel(IConfiguration config)
        {
            _config = config;
        }
        public string Message { get; set; }

        public void OnGet()
        {
            var email = _config["Contact:Email"];
            var groupName = _config["Group:Name"];
            Message = $"Your Email is {email} and you belong to {groupName}";
        }
    }
}
