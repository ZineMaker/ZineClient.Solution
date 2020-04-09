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

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      ApplicationUser dev = new ApplicationUser { UserName = "user@developer", FirstName = "Foo", LastName = "Bar" };

      builder.Entity<ApplicationUser>()
        .HasData(
          dev
        );

      builder.Entity<Organization>()
        .HasData(

          new Organization { OrganizationId = 1, Name = "The Sample Org", MainImageUrl = "https://www.geniuscr8.com/wp-content/uploads/2018/07/Genius-Concept-Sample-Logo-2.jpg", Description = "We are a small grassroots community of creators committed to bringing you high quality content for the current era" },

          new Organization { OrganizationId = 2, Name = "Makers of Ctrl+V", MainImageUrl = "https://turbologo.com/articles/wp-content/uploads/2018/03/prozrachniy-logo-1-1280x720.png", Description = "Pasting (and cutting, copying, etc.) is the name of the game for this paper-turned-digital media project" },

          new Organization { OrganizationId = 3, Name = "West Seattle Connection", MainImageUrl = "https://cdn.vox-cdn.com/thumbor/2KfYhzovz49NNJ5aBw9agDxWoAo=/0x0:4000x3000/1200x800/filters:focal(1541x1365:2181x2005)/cdn.vox-cdn.com/uploads/chorus_image/image/65976577/shutterstock_1386088199.0.jpg", Description = "We pride ourselves on transparency and keeping the public informed. Check out our West Seattle Connection blog" }
        );

      builder.Entity<Zine>()
      .HasData(
          new Zine { ZineId = 1, OrganizationId = 2, Name = "Ctrl+V I", Description = "The zine of your dreams", MainImageUrl = "https://cms-assets.tutsplus.com/uploads/users/114/posts/32493/image/Mockup1.jpg", PublicationDate = System.DateTime.Now, IssueNumber = 1 },

          new Zine { ZineId = 2, OrganizationId = 2, Name = "Ctrl+V II", Description = "The zine of your dreams, remastered", MainImageUrl = "https://texlibris.lib.utexas.edu/wp-content/uploads/2020/02/17-01898_3600-712x1024.jpg", PublicationDate = System.DateTime.Now, IssueNumber = 2 },

          new Zine { ZineId = 3, OrganizationId = 2, Name = "Ctrl+V III", Description = "The zine of your dreams, trilogy edition", MainImageUrl = "https://images.squarespace-cdn.com/content/v1/5b69d5843917eed82e6834fc/1537917947123-QPP10RP1SC469FXQXP45/ke17ZwdGBToddI8pDm48kHTjdXaoHj2XBS1xQ9Jx_M57gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z5QPOohDIaIeljMHgDF5CVlOqpeNLcJ80NK65_fV7S1Uei60Zpw-ZuEzVY2XSpngzHUNhdVwAOL_XMz32vi4iSsh9ymnU-gXScjHEMuNgenFw/The+Joy+003-Cover-spreads.jpg?format=2500w", PublicationDate = System.DateTime.Now, IssueNumber = 4 },

          new Zine { ZineId = 4, OrganizationId = 2, Name = "Ctrl+C", Description = "The zine for when the zine of your dreams already existed", MainImageUrl = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/380a5783-bac6-4184-9776-270b1e3b6a1d/dchzmx3-4b7e18cb-02cb-41ce-a192-ccb57c77e763.png/v1/fill/w_1024,h_1453,q_80,strp/shindeku_zine_cover____by_neon_nuisance_dchzmx3-fullview.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9MTQ1MyIsInBhdGgiOiJcL2ZcLzM4MGE1NzgzLWJhYzYtNDE4NC05Nzc2LTI3MGIxZTNiNmExZFwvZGNoem14My00YjdlMThjYi0wMmNiLTQxY2UtYTE5Mi1jY2I1N2M3N2U3NjMucG5nIiwid2lkdGgiOiI8PTEwMjQifV1dLCJhdWQiOlsidXJuOnNlcnZpY2U6aW1hZ2Uub3BlcmF0aW9ucyJdfQ.UfjaWa0T3nF6rngtM2Fg0mW036EwLWIC4eZKmuEH_U4", PublicationDate = System.DateTime.Now, IssueNumber = 1 },

          new Zine { ZineId = 5, OrganizationId = 1, Name = "Devs Digest", Description = "Asp.NET Core 101: A crash course", MainImageUrl = "https://dispozitivbooks.com/wp-content/uploads/2020/03/8.jpg", PublicationDate = System.DateTime.Now, IssueNumber = 1 },

          new Zine { ZineId = 6, OrganizationId = 1, Name = "Team Week in the making", Description = "Our unfiltered opinions on group projects, late nights, and quarantine blues", MainImageUrl = "https://pbs.twimg.com/media/ETy7wcJWsAEplrI.jpg", PublicationDate = System.DateTime.Now, IssueNumber = 2 },

          new Zine { ZineId = 7, OrganizationId = 3, Name = "About West Seattle", Description = "Though it's isolated from the rest of the city, West Seattle is an incredibly popular area, whether it's to live in or just to visit one of its hip neighborhoods.", MainImageUrl = "https://cdn.vox-cdn.com/thumbor/tyONoySTF3e4Qq64-86lCk9DdZA=/0x0:2500x1295/1200x900/filters:focal(751x398:1151x798)/cdn.vox-cdn.com/uploads/chorus_image/image/54721251/west_seattle_shutterstock.0.jpg", PublicationDate = System.DateTime.Now, IssueNumber = 1 },

          new Zine { ZineId = 8, OrganizationId = 3, Name = "West Seattle Library", Description = "The renovated West Seattle Branch opened April 3, 2004. At this Carnegie library, tall ceilings contribute to a sense of openness. Rich detailing and use of wood throughout the interior add to the warm, historic feel.", MainImageUrl = "https://pauldorpat.com/wp-content/uploads/2011/12/branches-color-postcard-web1.jpg?w=500&h=309", PublicationDate = System.DateTime.Now, IssueNumber = 2 }
      );

      builder.Entity<Post>()
      .HasData(
          new Post { PostId = 1, Title = "Sample Post", Source = "https://www.npr.org/2019/03/19/704428358/the-new-me-is-meh-about-ambition-and-adulthood", Body = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", MainImageUrl = "https://media.npr.org/assets/bakertaylor/covers/t/the-new-me/9780143133605_custom-032ec0143cbe2b6613d2f46cb11228fc7fa84521-s300-c85.jpg", Published = System.DateTime.Now },

          new Post { PostId = 2, Title = "In An Age Of Screens, Looking For 'Attention' In All The Wrong Places", Source = "https://www.npr.org/2020/04/08/828800691/in-an-age-of-screens-looking-for-attention-in-all-the-wrong-places", Body = "'This story begins with the Adderall,' opens Casey Schwartz's Attention: A Love Story. In 2000, Schwartz was in college, struggling to write an essay, when a friend offered her a pill 'the deep bright blue of a cartoon sky' and her hand 'shot out to receive it.'Here already are the seeds of what is coming: It is not 'Adderall' but 'the Adderall,' not the serviceable 'take' or 'grab' but the sacramental 'receive.'Schwartz fell in love. Adderall was 'attention weaponized, slashing through procrastination and self-doubt, returning me to a place that felt almost like childhood, with its unclouded pleasures of rapt hours, lost in books and imagination. Childhood, but with a jittery amphetamine edge...'", MainImageUrl = "https://media.npr.org/assets/bakertaylor/covers/a/attention/9781524747107_custom-5554b06219ed55f1cabc3e970c2bb37de6a89840-s300-c85.jpg", Published = new System.DateTime(2020, 4, 8) },

          new Post { PostId = 3, Title = "Need An Escape? Try 'Unorthodox,' 'Baghdad Central' And 'Abigail'", Source = "https://www.npr.org/2020/04/06/828085961/need-an-escape-try-unorthodox-baghdad-central-and-abigail", Body = "The Russian poet Joseph Brodsky once said that prison is a lack of space counterbalanced by a surplus of time. Our current lockdown can't be compared to being locked up, but with so much surplus time on our hands, many of us are eager for stories that will help us escape endless thoughts of COVID-19. Here are three that did that for me: Unorthodox This desire for escape underlies the appeal of Unorthodox, the four-part Netflix series that has viewers whooshing through it in a single night. Loosely based on a memoir by Deborah Feldman, it stars Israeli actor Shira Haas as 19-year-old Esther 'Esty' Shapiro, a woman who flees her marriage and her tight Hasidic community in Williamsburg, Brooklyn. Esty jets off to Berlin, where a group of music students take her under their wing. Meanwhile, she's pursued by her husband, Yanky (Amit Rahav), and his cousin Moishe (Jeff Wilbusch), who's something of a thug.", MainImageUrl = "https://media.npr.org/assets/img/2020/04/06/anika-molnar-netflix_wide-37dbf151aa711845cd3336cdacf929c135f1d46b-s800-c85.jpg", Published = new System.DateTime(2020, 4, 6) },

          new Post { PostId = 4, Title = "Charming 'Hex' Insists On Beauty And Joy", Source = "https://www.npr.org/2020/04/04/826891969/charming-hex-insists-on-beauty-and-joy", Body = "Rebecca Dinerstein Knight's strange and delightful second novel, Hex, opens with its protagonist in crisis. Nell Barber is an ex-doctoral student at Columbia; her lab, which studied toxins, has been disbanded after a student accidentally poisons herself, and now Nell is floating through New York, grief-stricken and in need of work. She's also profoundly lovesick for her dissertation advisor, a magnetic young botanist named Dr. Joan Kallas. Without Joan's 'absolutely necessary nearness,' Nell is undone. She describes herself as 'deleted.' She spends her time cooking up ways to continue her research without a lab; writing long letters to Joan in composition notebooks; and seeking beauty wherever she can find it.", MainImageUrl = "https://media.npr.org/assets/bakertaylor/covers/h/hex/9781984877376_custom-d7f85cab68b5281986f54966f07ac251b2432495-s300-c85.jpg", Published = new System.DateTime(2020, 4, 4) },

          new Post { PostId = 5, Title = "Bridge now", Source = "West Seattle Connection", Body = "Here's the West Seattle Bridge on Sept. 19, 2015. See any cracks? Nope. Photo by Patrick Robinson.", MainImageUrl = "https://www.westsideseattle.com/sites/default/files/images/%5Bdomain-url%5D/%5Bnode-yyyy%5D/%5Bnode-mm%5D/252a9949_copy.jpg", Published = System.DateTime.Now },

          new Post { PostId = 6, Title = "Party House", Source = "West Seattle Connection", Body = "Anyone on here that used to go to the Party House in White Center, sad to say that my Dad, Hurley Ring has passed away at the age of 94. He owned and ran the Party House for 36 years from 1952 to 1988. He loved his time running the store and meeting so many people, many of whom became good friends! He had a great run! Thanks to all of you who made it memorable for him!", MainImageUrl = "https://d3h6k4kfl8m9p0.cloudfront.net/uploads/2014/04/1920-washington-DC-shorpy.jpg", Published = System.DateTime.Now },

          new Post { PostId = 7, Title = "Bicycle Person", Source = "West Seattle Connection", Body = "I saw this person on a high rise bicycle coming down Highland Park Way today. It’s always fun to see people doing interesting things like this, not to mention the skill of using a bus stop sign to hold yourself on a hill! EDIT: one of the commenters identified this person as Aaron from Aaron's Bicycle Repair in White Center. The website lists his shop as open. If you are in need of such services, be sure to keep his business in mind.", MainImageUrl = "https://static1.squarespace.com/static/53dd6676e4b0fedfbc26ea91/54b6c509e4b062126976d942/5a57a1d7c8302558ef0605cc/1516298184024/bike_girl_panning_bicycle_cycle_cyclist_outdoor_ride-1168194.jpg?format=2500w", Published = System.DateTime.Now },

          new Post { PostId = 8, Title = "Psychic Barber", Source = "West Seattle Connection", Body = "I haven’t laughed so hard in weeks... not even all the memes can beat this. I was standing there laughing and he even came out to say hello! Thank you Psychic Barber!!", MainImageUrl = "https://media-cdn.tripadvisor.com/media/photo-m/1280/14/ff/61/25/getlstd-property-photo.jpg", Published = System.DateTime.Now },

          new Post { PostId = 9, Title = "Our Bridge", Source = "West Seattle Connection", Body = "Given the state of the West Seattle Bridge does anyone else think we should be revisiting the decision not to tunnel under the Duwamish for our light rail? Perhaps a tunnel for both traffic and light rail might make the project more cost effective given the cost we’re currently facing to repair a crumbling bridge, and building another huge bridge for light rail, and with the economic costs of having the bridge out of commission for an unknown period of time? *pic taken June 2019. My Son and I noticed them working on the bridge cracks throughout 2019", MainImageUrl = "https://static.seattletimes.com/wp-content/uploads/2020/03/03242020_bridge_134121-1560x1040.jpg", Published = System.DateTime.Now }
      );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}