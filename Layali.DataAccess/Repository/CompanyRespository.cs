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
    public class CompanyRespository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _db;
        public CompanyRespository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
