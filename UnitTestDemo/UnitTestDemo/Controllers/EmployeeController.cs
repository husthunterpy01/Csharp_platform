using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using UnitTestDemo.Model;
using UnitTestDemo.Service;

namespace UnitTestDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var listEmployee = _employeeService.GetAll();
            return Ok(listEmployee);
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var employeeById = _employeeService.GetById(id);
            if (employeeById == null)
            {
                return NotFound();
            }
            return Ok(employeeById);
        }
        [HttpPost]
        public ActionResult AddEmployee([FromRoute] Employee emp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var addEmp = _employeeService.AddEmployee(emp);
            return CreatedAtAction("Get", addEmp);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteById(int id)
        {
            if( _employeeService.DeleteEmployee(id))
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
