using Domain.Models;
using Infrastructure.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class UsersController
{
    readonly UserService userService;

    public UsersController()
    {
        userService = new UserService();
    }

    [HttpGet("GetAllUsers")]
    public List<Users> GetAllUsers()
    {
        return userService.GetUsers();
    }

    [HttpGet("GetUserById/{id}")]
    public Users GetUserById(int id)
    {
        return userService.GetUserById(id);
    }

    [HttpPost("AddUser")]
    public string AddUser(Users user)
    {
       return userService.AddUser(user);
    }

    [HttpPut("UpdateUser")]
    public string UpdateUser(Users user)
    {
        return userService.UpdateUser(user);
    }

    [HttpDelete("DeleteUser/{id}")]
    public bool DeleteUser(int id)
    {
        return userService.DeleteUser(id);
    }
}