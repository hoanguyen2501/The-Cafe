namespace CoffeeBook.Models
{
    public class News
    {
        private int id;
        private string title;
        private string content;
        private string thumbnail;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string Thumbnail { get => thumbnail; set => thumbnail = value; }
    }
}