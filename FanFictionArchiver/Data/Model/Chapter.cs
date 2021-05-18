// FILE: Chapter.cs
// PROJECT: FanFictionArchiver
// SOLUTION: FanFictionArchiver
// -------------------------------------------
// AUTHOR: Sean Hennessey
// DATE CREATED: 2021-05-16
// DATE MODIFIED: 2021-05-16

namespace FanFictionArchiver.Data.Model
{
    public class Chapter
    {
        public Story Story { get; set; }
        public int StoryId { get; set; }
        public int ChapterIndex { get; set; }
        public string Title { get; set; }

        public WebAddress WebAddress { get; set; }
        public int WebAddressId { get; set; }
    }
}