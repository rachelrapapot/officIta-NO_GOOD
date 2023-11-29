using studentsMark.core.Repositories;
using studentsMark.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsMark.service
{
    public class c: IStudentServies
    {
        private readonly IStudntRepositories _StudntRepositories;
        public StudentServiescs(IStudntRepositories StudntRepositories)
        {
            _StudntRepositories = StudntRepositories;
        }

        public List<students> GetStudent()
        {
            return _StudntRepositories.GetAllStudnt();
        }
    }
}
