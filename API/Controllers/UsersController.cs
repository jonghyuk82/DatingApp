using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
=======
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
>>>>>>> ae64c8dae4a3c8db8782a7927cf8811a63b85045

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
<<<<<<< HEAD
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
=======
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            return _context.Users.ToList();
>>>>>>> ae64c8dae4a3c8db8782a7927cf8811a63b85045
        }

        // api/users/3
        [HttpGet("{id}")]
<<<<<<< HEAD
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
=======
        public ActionResult<AppUser> GetUser(int id)
        {
            return _context.Users.Find(id);
>>>>>>> ae64c8dae4a3c8db8782a7927cf8811a63b85045
        }
    }
}