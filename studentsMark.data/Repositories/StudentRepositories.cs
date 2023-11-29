using studentsMark.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsMark.data.Repositories
{
    public class StudentRepositories: IStudntRepositories
    {
        private readonly DataContext _context;

        public StudentRepositories(DataContext dataContext)
        {
            _context = dataContext;
        }

        public List<students> GetAllStudnt()
        {
            return _context.Student;
        }
    }
}
