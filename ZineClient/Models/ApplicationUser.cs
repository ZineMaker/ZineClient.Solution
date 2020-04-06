using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ZineClient.Models
{
  public class ApplicationUser : IdentityUser
  {
    // public int ApplicationUserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public virtual ICollection<ApplicationUserOrganization> Organizations { get; set; }
    public virtual ICollection<Post> Posts { get; set; }

    public ApplicationUser() : base()
    {
      this.Organizations = new HashSet<ApplicationUserOrganization>();
      this.Posts = new HashSet<Post>();
    }
  }
}