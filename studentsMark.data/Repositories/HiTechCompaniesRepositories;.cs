using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentsMark.core;
using studentsMark.core.Repositories;
namespace studentsMark.data.Repositories
{
    public class HiTechCompaniesRepositories_: ICompaniesRepositories
    {
            private readonly DataContext _context;

            public HiTechCompaniesRepositories_(DataContext dataContext)
            {
                _context = dataContext;
            }

            public List<Companies> GetAllCompanies()
            {
            return _context.companies;
            }
        
    }
}
