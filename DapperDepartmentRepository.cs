using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DapperPractice
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;

        public DapperDepartmentRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("select * from Departments;");
        }

        public void InsertDepartment(string newDepartmentName)
        {
            _connection.Execute("Insert into Departments (Name) Values (@departmentName);", 
                new {departmentName = newDepartmentName});
        }
    }
}
