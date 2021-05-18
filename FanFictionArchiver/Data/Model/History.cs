// FILE: History.cs
// PROJECT: FanFictionArchiver
// SOLUTION: FanFictionArchiver
// -------------------------------------------
// AUTHOR: Sean Hennessey
// DATE CREATED: 2021-05-16
// DATE MODIFIED: 2021-05-16

namespace FanFictionArchiver.Data.Model
{
    using System;
    using System.Security.Policy;

    public class History
    {
        public int Id { get; set; }
        public DateTime VisitDat { get; set; }
        public WebAddress WebAddress { get; set; }
        public int WebAddressId { get; set; }
    }
}