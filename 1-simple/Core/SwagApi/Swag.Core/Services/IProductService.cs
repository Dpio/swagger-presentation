using System;
using System.Collections.Generic;
using Swag.Core.Models;

namespace Swag.Core.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetById(Guid id);
    }
}