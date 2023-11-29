using studentsMark.core.Repositories;
using studentsMark.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsMark.service
{
    public class TeacherServies: ITeacherServies
    {
        private readonly ITeacherRepositories _TeacherRepositories;
        public TeacherServies(ITeacherRepositories TeacherRepositories)
        {
            _TeacherRepositories = TeacherRepositories;
        }

        public List<Teacher> GetTeacher()
        {
            return _TeacherRepositories.GetAllTeacher();
        }

    
    }
}
