﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WpfApp1.Models.Domains
{
    public class Group
    {
        public Group()
        {
            Students = new Collection<Student>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
