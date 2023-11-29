using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsMark.core.Repositories
{
    public interface ITeacherRepositories
    {
        List<Teacher> GetAllTeacher();
    }
}
