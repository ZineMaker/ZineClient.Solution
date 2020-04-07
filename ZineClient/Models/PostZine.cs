namespace ZineClient.Models
{
  public class PostZine
  {
    public int PostZineId { get; set; }
    public int PostId { get; set; }
    public int ZineId { get; set; }
    public virtual Post Post { get; set; }
    public virtual Zine Zine { get; set; }
  }
}