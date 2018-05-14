using System;
using System.Collections.Generic;
using System.Linq;
using Swag.Core.Models;

namespace Swag.Core.Services.Impl
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetAll()
        {
            return LoadProducts();
        }

        public Product GetById(Guid id)
        {
            return LoadProducts().First(product => product.Id == id);
        }

        private IEnumerable<Product> LoadProducts()
        {
            var alcoholCategory = GetAlcoholCategory();
            var beer = new Product()
            {
                Category = alcoholCategory,
                CategoryId = alcoholCategory.Id,
                Id = new Guid("FB3EFC93-9789-4597-A1C9-6C1325A21107"),
                Code = "P001",
                Name = "Beer"
            };
            var vodka = new Product()
            {
                Category = alcoholCategory,
                CategoryId = alcoholCategory.Id,
                Id = new Guid("F6F3EFC3-D01D-4431-B7D5-C15F2EB60955"),
                Code = "P002",
                Name = "Vodka"
            };
            var dairyCategory = GetDairyCategory();
            var milk = new Product()
            {
                Category = dairyCategory,
                CategoryId = dairyCategory.Id,
                Id = new Guid("CDDF7649-42AF-405F-BC21-92C9F0AD3008"),
                Code = "P003",
                Name = "Milk 3%"
            };
            var lightMilk = new Product()
            {
                Category = dairyCategory,
                CategoryId = dairyCategory.Id,
                Id = new Guid("26089F58-28B2-46B9-B4EA-93E5ABDE5674"),
                Code = "P004",
                Name = "Milk 0.5%"
            };
            var sourCream = new Product()
            {
                Category = dairyCategory,
                CategoryId = dairyCategory.Id,
                Id = new Guid("E0108136-6529-499F-910F-A2F99D82BB05"),
                Code = "P005",
                Name = "Sour cream 30%"
            };

            return new List<Product>()
            {
                beer,
                vodka,
                milk,
                lightMilk,
                sourCream
            };
        }

        private Category GetSweetsCategory()
        {
            var sweetsCategory = new Category
            {
                Code = "C003",
                Id = new Guid("5C6E7177-E808-4DCE-9D3D-EFF564FFFA1D"),
                Name = "Sweets"
            };
            return sweetsCategory;
        }

        private Category GetAlcoholCategory()
        {
            var alcoholCategory = new Category
            {
                Code = "C002",
                Id = new Guid("7E6F4263-AB6F-42E9-B6B1-DAB0C8B1D1EC"),
                Name = "Alcohol"
            };
            return alcoholCategory;
        }

        private Category GetDairyCategory()
        {
            var dairyCategory = new Category
            {
                Code = "C001",
                Id = new Guid("798C4C82-4DC2-4E28-92D1-9F6E10DBD778"),
                Name = "Dairy"
            };

            return dairyCategory;
        }
    }
}