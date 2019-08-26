
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

   
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employees.Single(x => x.EmployeeId == id);

            // Employee employee = employeeContext.Employees

            return View(employee);
        }
    }
}