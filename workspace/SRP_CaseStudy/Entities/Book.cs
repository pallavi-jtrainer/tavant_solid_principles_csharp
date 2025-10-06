using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CaseStudy.Entities
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";

        public string Author { get; set; } = "";

        public bool isAvailable { get; set; } = true;
    }
}
