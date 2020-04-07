using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ZineClient.Models
{
  public class ZineClientContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Organization> Organizations { get; set; }
    public DbSet<Zine> Zines { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Tag> Tags { get; set; }

    public DbSet<ApplicationUserOrganization> ApplicationUserOrganization { get; set; }
    public DbSet<PostTag> PostTag { get; set; }
    public DbSet<PostZine> PostZine { get; set; }

    public ZineClientContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}