using System;
using gachiBlazorServer.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace gachiBlazorServer.Data.Services
{
	public class UserService
	{
        private DbContext _context; // The context is configured to use the SQL Server database provider and will read the connection string from ASP.NET Core configuration

        [HttpPost]
        public Task<User> CreateUser(User user)
        {
            /*  _context.Users.Add(user); 

             _context.SaveChanges(); */

            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<User> GetUserByIdAsync(int id)
        {

            /*var user =await  _context.Users.Find(id);

            return user; */

            throw new NotImplementedException();
        }


        [HttpDelete]
        public Task DeleteUser(int id)
        {
            /* var user = GetUserByIdAsync(id);

             _context.Organizations.Remove(user);
             _context.SaveChanges(); */

            throw new NotImplementedException();
        }
    }
}

