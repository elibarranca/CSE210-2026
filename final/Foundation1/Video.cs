class Video
{
    public string _title = "";
    public string _author = "";
    public int _length = 0;
    public List<Comment> _comments = new List<Comment>();

    public int NumComments()
    {
        int count = 0;
        foreach (Comment comment in _comments)
        {
            count++;
        }
        return count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"video Title: {_title}");
        Console.WriteLine($"Video Author: {_author}");
        Console.WriteLine($"video length: {_length} seconds");
        Console.WriteLine($"Comments: {NumComments()}");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment._commenterName}, {comment._commentText}");
        }

    }
}