using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_Kaido16.Models
{
    public class Book
    {
        public int id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string ISBN { get; set; }
        public string PublishDate { get; set; }
    }
}