using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Checkpoint_3.Models
{
    public class User : IdentityUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Article> Article { get; set; }
    }
}