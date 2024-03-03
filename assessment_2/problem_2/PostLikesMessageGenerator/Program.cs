namespace PostLikesMessageGenerator;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>();

        Console.WriteLine("Enter the names of people who liked your post (press Enter to finish):");
        string input;
        //this block is executed atleast once no matter the condition
        do
        {
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                names.Add(input);
            }
        } while (!string.IsNullOrWhiteSpace(input));

        DisplayLikeMessage(names);
    }

    static void DisplayLikeMessage(List<string> names)
    {
        int count = names.Count;

        //Generates the message depending upon the count of people who liked the posts
        switch (count)
        {
            case 0:
                // No one likes your post
                break;
            case 1:
                // One person likes your post
                Console.WriteLine(names[0] + " likes your post.");
                break;
            case 2:
                // Two people like your post
                Console.WriteLine(names[0] + " and " + names[1] + " like your post.");
                break;
            default:
                // More than two people like your post
                Console.Write(names[0] + ", " + names[1] + " and " + (count - 2) + " others like your post.");
                break;
        }
    }
}
