﻿namespace YouTubeVideos
{
    class Comment
    {
        private string _name;
        private string _text;

        public Comment(string name, string text)
        {
            _name = name;
            _text = text;
        }

        public void DisplayComment()
        {
            Console.WriteLine($"NAME: {_name} , comment : {_text}");
        }


    }
}
