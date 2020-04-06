using System.Collections.Generic;
using System;

namespace ZineClient.Models
{
  public class Post
  {
    public int PostId { get; set; }
    // public int ApplicationUserId { get; set; }
    public virtual ApplicationUser ApplicationUser { get; set; }
    public string Title { get; set; }
    public string Source { get; set; } // if content needs to be cited/link to outside site
    public string Body { get; set; }  // public byte[] Body {get;set;}

    // public string Slug { get; set; }
    public DateTime Published { get; set; }

    // public DateTime Updated { get; set; }
    public virtual ICollection<PostTag> Tags { get; set; }
    public virtual ICollection<PostZine> Zines { get; set; }

    public Post()
    {
      this.Tags = new HashSet<PostTag>();
      this.Zines = new HashSet<PostZine>();
    }
  }
}