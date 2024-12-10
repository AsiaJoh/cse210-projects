class Video
{
    string _title;
    string _author;
    int _length;
    List<Comment> _comments = new List<Comment> {};
    

    // Constructor(s)
    public Video()
    {
        // Assigning the default values
        _title = "Default Video Title";
        _author = "John Smith";
        _length = 5;

    }

    // Methods
    public int CommentsCount() {
        // Return the number of comments
        int numComments = _comments.Count;
        return numComments;
    }

    public void DisplayVideo() {
        // Display the title, author, length, number of comments (from the method) 
        int numComments = CommentsCount(); 
        string videoData = $"Video Title: {_title} \nVideo Author: {_author} \nVideo Length: {_length} minute(s) \nVideo Comment Count: {numComments}\n";
        Console.WriteLine(videoData);
    }

    public void DisplayCommentsList() {
        // List out all of the comments for that video.
        foreach (Comment comment in _comments) { 
            comment.DisplayComment();
        }
    }

    public void AppendComment(Comment comment) {
        _comments.Add(comment);
    }



    // Getters/Setters
    public string GetTitle() {
        return _title;
    }
    public string GetAuthor() {
        return _author;
    }
    public int GetLength() {
        return _length;
    }
    public List<Comment> GetCommentsList() {
        return _comments;
    }

    public void SetTitle(string title) {
        _title = title;
    }
    public void SetAuthor(string author) {
        _author = author;
    }
    public void SetLength(int length) {
        _length = length;
    }
    public void SetCommentsList(List<Comment> commentList) {
        _comments = commentList;
    }
}