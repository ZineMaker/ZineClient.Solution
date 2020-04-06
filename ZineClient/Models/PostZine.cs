namespace ZineClient.Models
{
  public class PostZine
  {
    public int PostZineId { get; set; }
    public int PostId { get; set; }
    public int ZineId { get; set; }
    public Post Post { get; set; }
    public Zine Zine { get; set; }
  }
}