﻿using Ecommerce.Application.DTOs;
using Ecommerce.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(IProductService productService) : ControllerBase
{
    private readonly IProductService _productService = productService;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDTO>>> GetAllProducts()
    {
        var products = await _productService.GetProducts();

        return Ok(products);
    }

    [HttpGet("{id}", Name = "GetProductsById")]
    public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProductsById(Guid id)
    {
        var products = await _productService.GetById(id);

        return Ok(products);
    }

    // [HttpGet("State")]
    // public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProdyctByState(bool sale, bool newProduct, bool topProduct ) 
    // {
    //     return Ok();
    //     //public bool Sale { get; private set; }
    //     //public bool NewProduct { get; private set; }
    //     //public bool TopProduct { get; private set; }
    //     //throw new NotImplementedException();
    // }

    // [HttpGet("category")]
    // public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProdyctByCategory(Guid CategoryId)
    // {
    //     return Ok();
    //     //public bool Sale { get; private set; }
    //     //public bool NewProduct { get; private set; }
    //     //public bool TopProduct { get; private set; }
    //     //throw new NotImplementedException();
    // }

    [HttpPost]
    public async Task<ActionResult> CreatNewProduct([FromBody] ProductDTO productDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _productService.Add(productDto);

        return new CreatedAtRouteResult("GetProductsById", new { id = productDto.ProductId, productDto });
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateOneProduct(int id, [FromBody] ProductDTO productDto)
    {
        if (id.ToString() != productDto.ProductId.ToString())
        {
            return BadRequest();
        }

        await _productService.Update(productDto);

        return Ok(productDto);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ProductDTO>> Delete(Guid id)
    {
        var productDto = await _productService.GetById(id);
        if (productDto == null)
        {
            return NotFound();
        }
        await _productService.Remove(id);
        return Ok(productDto);
    }










}
