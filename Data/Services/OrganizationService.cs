﻿using gachiBlazorServer.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace gachiBlazorServer.Data.Services
{
    public class OrganizationService
    {
        private DbContext _context; // The context is configured to use the SQL Server database provider and will read the connection string from ASP.NET Core configuration

        [HttpPost]
        public  Task<Organization> CreateOrganization(Organization organization)
        {
           /*  _context.Organizations.Add(organization); 

            _context.SaveChanges(); */

           throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<Organization> GetOrganizationByIdAsync(int id)
        {

            /*var organization =await  _context.Organizations.Find(id);

            return organization; */

            throw new NotImplementedException();
        }


        [HttpGet]
        public async Task<List<Organization>> GetOrganizationsByLocationAsync(string location) //param could be city and zipcode
        {
            //Tammi's notes- rather than location, we could likely just query by city or zipcode
            //so linq would be something like Organization.Select(q => q.Address).Where(t => t.City == city)
           /* var organizations = await _context.Organizations.Where(x => x.Location == location);
  
            return organziations; */

            throw new NotImplementedException();
        }

        [HttpDelete]
        public Task DeleteOrganization(int id)
        {
           /* var organziation = GetOrganizationByIdAsync(id);

            _context.Organizations.Remove(organziation);
            _context.SaveChanges(); */

            throw new NotImplementedException();
        }



    }
}
