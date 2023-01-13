﻿using BlogApiUygulama.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApiUygulama.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class DefaultController : ControllerBase
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult EmployeeList()
        {
            var values = c.Employees.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult EmployeeAdd(Employee employee)
        {
            c.Add(employee);
            c.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult EmployeeGet(int id)
        {
            var employee = c.Employees.Find(id);
            if(employee==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(employee);    
            }
        }
        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {
            var employee = c.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(employee);
                c.SaveChanges();
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult EmployeeUpdate(Employee employee)
        {
            var emp = c.Find<Employee>(employee.ID);
            if (emp == null)
            {
                return NotFound();
            }
            else
            {
                emp.Name = employee.Name;
                c.Update(emp);
                c.SaveChanges();
                return Ok();
            }
        }

    }
}
