using Domain.Models;
using Infrastructure.Services.MarketService;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class MarketsController
{
    readonly MarketService _marketService;

    public MarketsController()
    {
        _marketService = new MarketService();
    }

    [HttpGet("GetAllMarkets")]
    public List<Markets> AllMarkets()
    {
        return _marketService.GetMarkets();
    }

    [HttpGet("GetMarketById/{id}")]
    public Markets GetMarketById(int id)
    {
        return _marketService.GetMarketById(id);
    }

    [HttpGet("AddMarket")]
    public string AddMarket(Markets market)
    {
        return _marketService.AddMarket(market);
    }

    [HttpPut("UpdateMarket")]
    public string UpdateMarket(Markets market)
    {
        return _marketService.UpdateMarket(market);
    }

    [HttpDelete("DeleteMarket/{id}")]
    public bool DeleteMarket(int id)
    {
         return _marketService.DeleteMarket(id);   
    }
    
}