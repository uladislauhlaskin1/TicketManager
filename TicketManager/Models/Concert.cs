﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace TicketManager.Models
{
    public class Concert
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SingerId { get; set; }
        public Singer Singer { get; set; }
        [Required]
        public int LocationId { get; set; }
        public Location Location { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Discriminator { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<PromoCode> PromoCodes { get; set; }

        public string ConcertType()
        {
            string[] split = Regex.Split(Discriminator, @"(?<!^)(?=[A-Z])");
            string s = "";
            foreach (string word in split)
            {
                s += $"{word}"; 
            }
            return s;
        }
    }
}