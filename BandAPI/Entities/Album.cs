﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BandAPI.Entities
{
    public class Album
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(400)]
        public string Description { get; set; }

        //Stablish the relationship between Album and Band
        [ForeignKey("BandId")]
        public Band Band { get; set; }
        public Guid BandId { get; set; } //As foreing key to Band


        public Album()
        {
        }
    }
}
