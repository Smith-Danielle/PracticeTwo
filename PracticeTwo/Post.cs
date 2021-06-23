using System;
namespace PracticeTwo
{
    public class Post
    {

        
        private string text;
        public Post()
        {
            Console.WriteLine("New post");
        }
        public string Text { get { return text; } set { text = value; } }
        public void ShowPost()
        {
            Console.WriteLine(text);
        }
    }
}
