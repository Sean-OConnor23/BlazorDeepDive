﻿using System.ComponentModel.DataAnnotations;

namespace BlazorDeepDive.Models
{
    public class Server
    {
        public Server()
        {
            int randomNumber = new Random().Next(0, 2);
            IsOnline = randomNumber == 0 ? false : true;
        }

        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? City {  get; set; }
        public bool IsOnline { get; set; }

    }
}
