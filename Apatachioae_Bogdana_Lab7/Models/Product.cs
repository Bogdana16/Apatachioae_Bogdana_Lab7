﻿using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Apatachioae_Bogdana_Lab7.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        [OneToMany]
        public List<ListProduct> ListProducts { get; set; }
    }
}
