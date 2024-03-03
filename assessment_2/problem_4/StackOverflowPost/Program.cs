namespace StackOverflowPost;

class Program
{
    static void Main(string[] args)
    {
        // Create a new post
        Post post = new Post("Sample Post", "This is a sample post for demonstration.");

        // Up-vote and down-vote the post
        post.UpVote();
        post.UpVote();
        post.UpVote();
        post.DownVote();
        post.UpVote();
        post.DownVote();
        post.UpVote();

        // Display the current vote value
        Console.WriteLine("Current Vote: " + post.Vote);
    }
}
