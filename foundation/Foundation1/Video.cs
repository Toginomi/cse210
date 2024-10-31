class Video
{
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
        this.comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public string GetVideoDetails()
    {
        return $"Title: {title}\nAuthor: {author}\nLength: {lengthInSeconds} seconds";
    }

    public void DisplayComments()
    {
        foreach (var comment in comments)
        {
            Console.WriteLine(comment.GetCommentDetails());
        }
    }
}