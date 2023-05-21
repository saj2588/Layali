using Layali.DataAccess.Data;
using Layali.DataAccess.Repository.IRepository;
using Layali.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Layali.DataAccess.Repository
{
    public class shoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository  
    {
        private ApplicationDbContext _db;
        public shoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
