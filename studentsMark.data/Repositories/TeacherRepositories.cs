using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using studentsMark.core.Repositories;


namespace studentsMark.data.Repositories
{
    public class TeacherRepositories: ITeacherRepositories
    {
            private readonly DataContext _context;

            public TeacherRepositories(DataContext dataContext)
            {
                _context = dataContext;
            } 
            public List<Teacher> GetAllTeacher()
            {
                return _context.teachers;
            }

          
        
    }
}
