// FILE: ChapterText.cs
// PROJECT: FanFictionArchiver
// SOLUTION: FanFictionArchiver
// -------------------------------------------
// AUTHOR: Sean Hennessey
// DATE CREATED: 2021-05-16
// DATE MODIFIED: 2021-05-16

namespace FanFictionArchiver.Data.Model
{
    public class ChapterText
    {
        public Story Story { get; set; }
        public int StoryId { get; set; }
        public Chapter Chapter { get; set; }
        public int ChapterIndex { get; set; }
        public string Text { get; set; }
    }
}