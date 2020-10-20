﻿using System;

namespace RazorPages_EventMaker.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public DateTime DateTime{ get; set; }

    }
}
