using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoopiWebMVC.Data;
using WoopiWebMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace WoopiWebMVC.Services
{
    public class DepartmentService
    {
        private readonly WoopiWebMVCContext _context;

        public DepartmentService(WoopiWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
