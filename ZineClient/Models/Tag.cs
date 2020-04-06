using System.Collections.Generic;

namespace ZineClient.Models
{
  public class Tag
  {
    public int TagId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<PostTag> Posts { get; set; }

    public Tag()
    {
      this.Posts = new HashSet<PostTag>();
    }
  }
}