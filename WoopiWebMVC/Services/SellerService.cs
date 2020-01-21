using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoopiWebMVC.Data;
using WoopiWebMVC.Models;

namespace WoopiWebMVC.Services
{
    public class SellerService
    {
        private readonly WoopiWebMVCContext _context;

        public SellerService(WoopiWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
