using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDapper.Models;

namespace WebApiDapper.IRepository
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployee();
        Task<Employee> GetById(int id);
        Task<List<Employee>> GetByDateOfBirth(DateTime dateOfBirth);
    }
}
