// FILE: Bookmark.cs
// PROJECT: FanFictionArchiver
// SOLUTION: FanFictionArchiver
// -------------------------------------------
// AUTHOR: Sean Hennessey
// DATE CREATED: 2021-05-16
// DATE MODIFIED: 2021-05-16

namespace FanFictionArchiver.Data.Model
{
    using System;

    public class Bookmark
    {
        public int Id { get; set; }
        public WebAddress WebAddress { get; set; }
        public int WebAddressId { get; set; }
        public string TargetType { get; set; }
        public string DisplayText { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime LastVisit { get; set; }
    }
}