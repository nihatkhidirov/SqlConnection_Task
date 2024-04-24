﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Migrations_Task.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public string NotMapped { get; set; }
        public List<BookGenre> BookGenre { get; set; }
    }
}
