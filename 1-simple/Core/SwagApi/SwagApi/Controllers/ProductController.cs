﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swag.Core.Models;
using Swag.Core.Services;

namespace SwagApi.Controllers
{
    /// <summary>
    /// All possible actions with products. 
    /// </summary>
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Get list of all products in the system.
        /// </summary>
        /// <returns>List of products.</returns>
        [HttpGet("getAll")]
        [Produces("application/json", Type = typeof(IEnumerable<Product>))]
        public IActionResult GetActive()
        {
            var dto = _productService.GetAll();
            if (dto == null)
            {
                return NotFound();
            }
            return Ok(dto);
        }

        /// <summary>
        /// Get single product.
        /// </summary>
        /// <param name="id">Product identifier type of Guid</param>
        /// <returns>Single product.</returns>
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(Product))]
        public IActionResult Get(Guid id)
        {
            var dto = _productService.GetById(id);
            if (dto == null)
            {
                return NotFound();
            }
            return Ok(dto);
        }
    }
}