using System;

namespace MochiSweets.Models
{
    public class News
    {
        public int newsID { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string postingTitle { get; set; }

        public News(){}
    }
}