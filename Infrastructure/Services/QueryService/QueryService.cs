
using Dapper;
using Infrastructure.DataContext;

namespace Infrastructure.Services.QueryService;

public class QueryService : IQueryService
{
    private readonly DapperContext _context;

    public QueryService()
    {
        _context = new DapperContext();
    }

    public List<string> UserOfMarket()// 1.Retrieve a list of all users and their market names.(Получить список всех пользователей и их названия рынков)
    {
        var sql = @"select 'user : '||u.firstname||' '||u.lastname||' market : '||m.market_name
                   from users as u
                   join markets as m on u.id = m.userid;";
        var res = _context.Connection().Query<string>(sql).ToList();
        return res;
    }

    public List<string> ProductOfCategory()//2.Retrieve a list of all products with their categories.(Получить список всех продуктов с их категориями.)
    {
        var sql = @"select 'producte name : '||p.name||'  category : '||c.name
                    from products as p
                    join categories as c on c.id =p.categoryid;";
        var res = _context.Connection().Query<string>(sql).ToList();
        return res;
    }
    
    

   
}