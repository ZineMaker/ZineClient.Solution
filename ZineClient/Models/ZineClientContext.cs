using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ZineClient.Models
{
  public class ZineClientContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Organization> Organizations { get; set; }
    public virtual DbSet<Zine> Zines { get; set; }
    public virtual DbSet<Post> Posts { get; set; }
    public virtual DbSet<Tag> Tags { get; set; }

    public DbSet<ApplicationUserOrganization> ApplicationsUserOrganization { get; set; }
    public DbSet<PostTag> PostTag { get; set; }
    public DbSet<PostZine> PostZine { get; set; }

    public ZineClientContext(DbContextOptions options) : base(options) { }
  }
}