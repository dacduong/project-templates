using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4Template
{
    public class Listing
    {
        [Key]
        public int id
        {
            get; set;
        }
        public string category
        {
            get; set;
        }
        public string name
        {
            get; set;
        }
        public string unit
        {
            get; set;
        }
        public string postal
        {
            get; set;
        }
        public string listing_timing
        {
            get; set;
        }
        public string email
        {
            get; set;
        }
        public string website
        {
            get; set;
        }
        public string description
        {
            get; set;
        }
        public string image
        {
            get; set;
        }
        public string address
        {
            get; set;
        }
        public double lat
        {
            get; set;
        }
        public double lng
        {
            get; set;
        }
        public string type
        {
            get; set;
        }
        public string category_term
        {
            get; set;
        }
        public long sid
        {
            get; set;
        }
        public string prefix_name
        {
            get; set;
        }
        public int brand_id
        {
            get; set;
        }
    }
}
