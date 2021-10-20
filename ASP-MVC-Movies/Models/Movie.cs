﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_Movies.Models
{
    public enum Genres
    {
        Action, Family, Comedy, Drama, Horror, Romance, Sports
    }

    /// <summary>
    /// Represents a movie in the database.
    /// </summary>
    public class Movie
    {
        [Key]
        public int ID { get; set; }

        [StringLength(60), Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public Genres Genre { get; set; }

        public decimal Price { get; set; }
    }
}