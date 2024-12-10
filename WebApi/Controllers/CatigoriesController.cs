using Domain.Models;
using Infrastructure.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class CatigoriesController
{
    readonly CategoryService _categoryService;

    public CatigoriesController()
    {
        _categoryService = new CategoryService();
    }

    [HttpGet("GetAllCatigories")]
    public List<Categories> GetAllCatigories()
    {
        return _categoryService.GetCategories();
    }

    [HttpGet("GetCatigoryById/{id}")]
    public Categories GetCatigoryById(int id)
    {
        return _categoryService.GetCategoryById(id);
    }

    [HttpPost("AddCatigory")]
    public string AddCatigory(Categories catigory)
    {
        return _categoryService.AddCategory(catigory);
    }

    [HttpPut("UpdateCatigory")]
    public string UpdateCatigory(Categories catigory)
    {
        return _categoryService.UpdateCategory(catigory);
    }

    [HttpDelete("DeleteCatigory/{id}")]
    public bool DeleteCatigory(int id)
    {
        return _categoryService.DeleteCategory(id);
    }
}