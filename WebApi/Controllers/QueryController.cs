using Infrastructure.Services.QueryService;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class QueryController
{
    readonly QueryService queryService;

    public QueryController()
    {
        queryService = new QueryService();
    }

    [HttpGet("Retrieve a list of all users and their market names")]
    public List<string> ListUserMarket()
    {
        return queryService.UserOfMarket();
    }

    [HttpGet("Retrieve a list of all products with their categories.")]
    public List<string> ListProductCategory()
    {
        return queryService.ProductOfCategory();
    }
        
}