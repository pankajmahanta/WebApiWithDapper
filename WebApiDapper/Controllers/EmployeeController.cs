using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDapper.IRepository;
using WebApiDapper.Models;

namespace WebApiDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Employee>> GetByID(int id)
        {
            return await _employeeRepository.GetById(id);
        }

        [HttpGet]
        [Route("dob/dateOfBirth")]
        public async Task<ActionResult<List<Employee>>> GetByDateOfBirth(DateTime dateOfBirth)
        {
            return await _employeeRepository.GetByDateOfBirth(dateOfBirth);
        }

        [HttpGet]
        [Route("getEmployee")]
        public async Task<ActionResult<List<Employee>>> GetEmployees()
        {
            return await _employeeRepository.GetEmployee();
        }

    }
}