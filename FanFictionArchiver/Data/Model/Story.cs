// FILE: Story.cs
// PROJECT: FanFictionArchiver
// SOLUTION: FanFictionArchiver
// -------------------------------------------
// AUTHOR: Sean Hennessey
// DATE CREATED: 2021-05-16
// DATE MODIFIED: 2021-05-16

namespace FanFictionArchiver.Data.Model
{
    using System;

    public class Story
    {
        public int Id { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Status { get; set; }

        public WebAddress WebAddress { get; set; }
        public int WebAddressId { get; set; }


    }
}