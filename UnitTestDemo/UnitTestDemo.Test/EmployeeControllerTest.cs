using Microsoft.AspNetCore.Mvc;
using UnitTestDemo.Controllers;
using UnitTestDemo.Model;
using UnitTestDemo.Service;

namespace UnitTestDemo.Test
{
    public class EmployeeControllerTest
    {
        EmployeeController _controller;
        IEmployeeService _service;
        public EmployeeControllerTest()
        {
            _service = new EmployeeService();
            _controller = new EmployeeController(_service);
        }

        // Following the pattern Arrange-Act-Assert
        [Fact]
        public void GetAllTest()
        {
            //Arrange
            int valid_id = 100;
            int invalid_id = 101;

            //Act
            var errorResult = _controller.GetById(invalid_id);
            var correctResult = _controller.GetById(valid_id);
            var correctModel = correctResult as OkObjectResult;
            var fetchedEmp = correctModel.Value as Employee;
            //Assert
            Assert.IsType<OkObjectResult>(correctModel);
            Assert.IsType<NotFoundResult>(errorResult);
            Assert.Equal(100, fetchedEmp.Id);
        }

        [Fact]
        public void AddEmployeeTest()
        {
            Employee emp = new Employee()
            {
                Id = 200,
                Name = "Jonathan",
                PhoneNo = "0732131",
                EmailId = "deka3@gmai.com"
            };
            var response = _controller.AddEmployee(emp);
            Assert.IsType<CreatedAtActionResult>(response);

            var createdEmp = response as CreatedAtActionResult;
            Assert.IsType<Employee>(createdEmp.Value);

            var empItem = createdEmp.Value as Employee;
            Assert.Equal("Jonathan", empItem.Name);
            Assert.Equal("0732131", empItem.PhoneNo);
            Assert.Equal("deka3@gmai.com", empItem.EmailId);
        }

        [Fact]
        public void DeleteEmployeeTest()
        {
            // Arrange
            int valid_id = 100;
            int invalid_id = 101;

            // Act
            var errorResult = _controller.DeleteById(invalid_id);
            var correctResult = _controller.DeleteById(valid_id);

            // Assert
            Assert.IsType<NotFoundResult>(errorResult);
            Assert.IsType<OkResult>(correctResult);
        }



    }
}