using Microsoft.AspNet.Identity.EntityFramework;


namespace CustomIdentityApp.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}