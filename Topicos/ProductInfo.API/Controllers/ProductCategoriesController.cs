﻿using Microsoft.AspNetCore.Mvc;
using ProductInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductInfo.API.Controllers
{
    [ApiController]
    [Route("api/products/{productId}/categories")]
    public class ProductCategoriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategories(int productId)
        {
            var product = ProductsDataStore.Current.ProductsList.FirstOrDefault(p => p.Id == productId);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product.ListOfCategories);
        }

        [HttpGet("{id}", Name = "GetCategory")]
        public IActionResult GetCategory(int productId, int id)
        {
            var product = ProductsDataStore.Current.ProductsList.FirstOrDefault(p => p.Id == productId);
            if (product == null)
            {
                return NotFound();
            }
            var category = product.ListOfCategories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]
        public IActionResult CreateCategory(int productId, [FromBody] Category theCategory)
        {
            var product = ProductsDataStore.Current.ProductsList.FirstOrDefault(p => p.Id == productId);
            if (product == null)
            {
                return NotFound();
            }

            //TODO:  autogenerated ID
            var maxCategoryId = ProductsDataStore.Current.ProductsList.SelectMany(p => p.ListOfCategories).Max(c => c.Id);

            // TODO:automember
            var finalCategory = new Category()
            {
                Id = maxCategoryId + 10,
                Name = theCategory.Name,
                Description = theCategory.Description
            };

            product.ListOfCategories.Add(finalCategory);

            return CreatedAtRoute("GetCategory",
                new
                {
                    productId = productId,
                    id = finalCategory.Id
                },
                    finalCategory
                );
        }

    }
}
