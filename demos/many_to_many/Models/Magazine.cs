using System;
using System.Collections.Generic;

namespace many_to_many.Models
{
    public class Magazine
    {
        public int MagazineId { get; set; }
        public string Title { get; set; }
        public List<Subscription> Readers { get; set; }
       
    }
}