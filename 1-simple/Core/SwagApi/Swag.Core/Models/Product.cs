﻿using System;
using System.ComponentModel;

namespace Swag.Core.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}