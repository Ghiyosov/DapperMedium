using Domain.Models;
using Infrastructure.Services.ProductService;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class ProductsController
{
    readonly  ProductService productService;

    public ProductsController()
    {
        productService = new ProductService();
    }

    [HttpGet("GetAllProducts")]
    public List<Products> GetAllProducts()
    {
        return productService.GetProducts();
    }

    [HttpGet("GetProductById/{id}")]
    public Products GetProductById(int id)
    {
        return productService.GetProductById(id);
    }

    [HttpPost("AddProduct")]
    public string AddProduct(Products product)
    {
        return productService.AddProduct(product);
    }

    [HttpPut("UpdateProduct")]
    public string UpdateProduct(Products product)
    {
        return productService.UpdateProduct(product);
    }

    [HttpDelete("DeleteProduct/{id}")]
    public bool DeleteProduct(int id)
    {
        return productService.DeleteProduct(id);
    }
}