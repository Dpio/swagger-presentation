using System;
using System.Collections.Generic;

namespace Swag.Core.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}