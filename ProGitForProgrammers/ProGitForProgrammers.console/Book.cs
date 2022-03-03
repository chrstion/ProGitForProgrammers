using System;
using System.Collections.Generic;

namespace ProGitForProgrammers.console
{
    public class Book
    {
        public string Title { get; set; }
        public List<string> Authors { get; set; }

        public DateTime PublicationDate { get; set; }
    }
}
