using System;
using System.Collections.Generic;

namespace ZineClient.Models
{
  public class Zine
  {
    public int ZineId { get; set; }
    public int OrganizationId { get; set; }

    public string Name { get; set; }
    public string Description { set; get; }
    public DateTime PublicationDate { get; set; }
    public int IssueNumber { get; set; }
    public virtual Organization Organization { get; set; }
    public virtual ICollection<PostZine> Posts { get; set; }

    public Zine()
    {
      this.Posts = new HashSet<PostZine>();
    }

  }
}