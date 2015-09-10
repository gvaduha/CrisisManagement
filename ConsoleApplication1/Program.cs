using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VA.CrisisManagement.Domain;
using VA.CrisisManagement.DbFacade;

namespace Infrastructure
{
    interface ServiceLocator
    {
        Uri findService(string serviceType);
    }
}

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            // Domain objects
            var p = new DomainObjects.Person();

            var e = new DomainObjects.Employee();

            var f = new DomainObjects.Family();

            Console.WriteLine(f.Members.First().birthDate.ToShortDateString());


            // HR App facade
            var x = new VA.CrisisManagement.DbFacade.CompoundFilter<VA.CrisisManagement.HrApplicationFacade.EmployeeFindFilter>()
            {
                one = new VA.CrisisManagement.HrApplicationFacade.EmployeeFindFilter(),
                two = new VA.CrisisManagement.HrApplicationFacade.EmployeeFindFilter(),
                comp = VA.CrisisManagement.DbFacade.FilterCompositor.and
            };

            // DB facade
            var e2 = e.getEmployees(null).FirstOrDefault();
            Console.WriteLine(e2.birthDate.ToShortDateString());
        }
    }
}
