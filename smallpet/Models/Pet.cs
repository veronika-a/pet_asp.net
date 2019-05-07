using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smallpet.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public string Link { get; set; }
    }
}