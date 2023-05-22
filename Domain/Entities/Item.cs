﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Store_Backend.Domain.Entities
{
    public class Item
    {
        public long Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        [MinLength(3)]
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "varchar(2000)")]
        public string? Description { get; set; }

        [Range(0, double.MaxValue)]
        [Required]
        public double? Price { get; set; }

        [Required]
        public byte[] Image { get; set; }

        [Required]
        public long CategoryId { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}