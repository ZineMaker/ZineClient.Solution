using System.Collections.Generic;

namespace ZineClient.Models
{
  public class Organization
  {
    public int OrganizationId { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }
    public virtual ICollection<ApplicationUserOrganization> ApplicationUsers { get; set; }

    public virtual ICollection<Zine> Zines { get; set; }

    public Organization()
    {
      this.ApplicationUsers = new HashSet<ApplicationUserOrganization>();
      this.Zines = new HashSet<Zine>();
    }
  }

}