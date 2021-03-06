﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesDemo.Core.Models
{
    public class MovieModel
    {
        public uint Id { get; set; }
        public string Title { get; set; }
        public string Runtime { get; set; }

        public string RelaseDate { get; set; }

        public string Director { get; set; }
        public string Description { get; set; }
        public string Poster { get; set; }
        public string LargePoster { get; set; }
        public string Genre { get; set; }

        public string Cast { get; set; }
    }
}
