﻿using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Tenant
    {
        [Key]
        public int TenantID {get; set;}
        public string? Namne {get; set;}
        public string?  Apartment {get; set;}     
        public string? Tag {get; set;}
    }
}
