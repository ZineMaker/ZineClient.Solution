namespace ZineClient.Models
{
  public class ApplicationUserOrganization
  {

    public int ApplicationUserOrganizationId { get; set; }
    // public int ApplicationUserId { get; set; }
    public int OrganizationId { get; set; }
    public virtual ApplicationUser ApplicationUser { get; set; }
    public virtual Organization Organization { get; set; }
  }

}