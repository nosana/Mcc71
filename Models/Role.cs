﻿using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
