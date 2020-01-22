using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoopiWebMVC.Data;
using WoopiWebMVC.Models;

namespace WoopiWebMVC.Services
{
    public class DepartmentService
    {
        private readonly WoopiWebMVCContext _context;

        public DepartmentService(WoopiWebMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
