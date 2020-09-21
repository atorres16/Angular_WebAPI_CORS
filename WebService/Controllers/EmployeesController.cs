using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebService.Models;

namespace WebService.Controllers
{
    [RoutePrefix("api/Employees")]
    public class EmployeesController : ApiController
    {

        [HttpGet]        
        public IHttpActionResult GetEmployees()
        {
            Employee[] employees = new Employee[4]
            {
                new Employee(){Id=1,Name="John Doe",Email="jdoe@email.com"},
                new Employee(){Id=1,Name="Jane Doe",Email="jadoe@email.com"},
                new Employee(){Id=1,Name="Juan Doe",Email="judoe@email.com"},
                new Employee(){Id=1,Name="Juana Doe",Email="juadoe@email.com"}
            };

            return Ok(employees);

        }
    }
}
