namespace YouTubeVideos
{
    class Video
    {
        private string _title;
        private string _author;
        private int _duration;
        private List<Comment> _comments = new List<Comment>();

        public Video(string title, string author, int duration)
        {
            _title = title;
            _author = author;
            _duration = duration;
        }

        public int GetCommentCount()
        {
            return _comments.Count;
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {_title}, Author: {_author}, Duration: {_duration} seconds, Comments: {GetCommentCount()}");

            foreach (var comment in _comments)
            {
                comment.DisplayComment();
            }

            Console.WriteLine("----------------------------");
        }
    }
}
