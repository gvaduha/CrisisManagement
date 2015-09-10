using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using VA.CrisisManagement.Domain;
using VA.CrisisManagement.DbFacade;

namespace BackEnd.Controllers
{
    public class EmployeesController : ApiController
    {
        private static DomainObjects.Employee dummy = new DomainObjects.Employee();

        // GET api/Employees
        public IEnumerable<DomainObjects.Employee> Get()
        {
            return dummy.getEmployees(null);
        }

        // GET api/Employees/...
        //TODO: we should use some format for filters: 
        // a) /name:john/age:30/...
        // b) /?name=john&age=30
        // check HTTP spec
        public IEnumerable<DomainObjects.Employee> Get(string filter)
        {
            return dummy.getEmployees(null);
        }
    }
}