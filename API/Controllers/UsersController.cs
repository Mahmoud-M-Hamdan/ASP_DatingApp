using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.data;
using API.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace API.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class UsersController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task <ActionResult<IEnumerable<AppUser>>> getUsers()
        {

            var users = await _context.Users.ToListAsync();

            return users;

        }


        [HttpGet("{id}")]
        public async Task <ActionResult<AppUser>> getUser(int id)
        {


            return await _context.Users.FindAsync(id);

        }




    }
}