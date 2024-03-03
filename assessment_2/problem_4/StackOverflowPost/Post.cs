namespace StackOverflowPost;

public class Post
{
    public string Title { get; }
    public string Description { get; }
    public DateTime CreationDateTime { get; }
    public int Vote { get; private set; }

    public Post(string title, string description)
    {
        Title = title;
        Description = description;
        CreationDateTime = DateTime.Now;
        Vote = 0;
    }

    public void UpVote()
    {
        Vote++;
    }

    public void DownVote()
    {
        Vote--;
    }
}