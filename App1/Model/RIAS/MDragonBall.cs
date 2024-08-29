using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1.Model.RIAS
{
    public class MDragonBall
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Ki { get; set; }
        public string MaxKi { get; set; }
        public string Race { get; set; } 
        public string Gender { get; set; }
        public string Description { get; set; }
        public string Image {  get; set; }
        public string Affiliation { get; set; }
        public DateTime? DeletedAt { get; set; }
    }

    public class ApiResponse
    {
        public List<MDragonBall> Items { get; set; }
        public Meta Meta { get; set; }
        public Links Links { get; set; }

    }

    public class Meta
    {
        public int TotalItems { get; set; }
        public int ItemCount { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
    }

    public class Links
    {
        public string First { get; set; }
        public string Previous { get; set; }
        public string Next { get; set; }
        public string Last { get; set; }

    }
}
