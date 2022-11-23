using System;
using System.Collections.Generic;
using System.Text;

namespace DapperPractice
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
