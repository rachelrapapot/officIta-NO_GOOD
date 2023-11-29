using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentsMark.core;
using studentsMark.core.Repositories;
using studentsMark.core.Services;
namespace studentsMark.service
{
    public class CompaniesServies : ICompaniesServies
    {
        private readonly ICompaniesRepositories _companiesRepositories ;
        public CompaniesServies(ICompaniesRepositories companiesRepositories)
        {
            _companiesRepositories= companiesRepositories ;
        }

        public List<Companies> GetCompanies()
        {
            return _companiesRepositories.GetAllCompanies();
        }
    }
}
