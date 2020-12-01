﻿using RepositoryDesignPatternUsingEFinMVC.DAL;
using RepositoryDesignPatternUsingEFinMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepositoryDesignPatternUsingEFinMVC.Controllers
{
    public class EmployeeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeeController()
        {
            _employeeRepository = new EmployeeRepository(new DAL.EmployeeDBContext());
        }

        public EmployeeeController(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = _employeeRepository.GetAll();

            return View(model);
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.Insert(model);
                _employeeRepository.Save();

                return RedirectToAction("Index", "Employee");
            }

            return View();
        }

        [HttpGet]
        public ActionResult EditEmployee(int EmployeeID)
        {
            Employee model = _employeeRepository.GetById(EmployeeID);

            return View(model);
        }

        [HttpPost]
        public ActionResult EditEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.Update(model);
                _employeeRepository.Save();
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public ActionResult DeleteEmployee(int EmployeeId)
        {
            Employee model = _employeeRepository.GetById(EmployeeId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int EmployeeID)
        {
            _employeeRepository.Delete(EmployeeID);
            _employeeRepository.Save();
            return RedirectToAction("Index", "Employee");
        }
    }
}