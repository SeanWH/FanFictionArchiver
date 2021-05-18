// FILE: Author.cs
// PROJECT: FanFictionArchiver
// SOLUTION: FanFictionArchiver
// -------------------------------------------
// AUTHOR: Sean Hennessey
// DATE CREATED: 2021-05-16
// DATE MODIFIED: 2021-05-16

namespace FanFictionArchiver.Data.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WebAddress WebAddress { get; set; }
        public int WebAddressId { get; set; }
    }
}