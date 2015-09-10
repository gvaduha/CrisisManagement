using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VA.CrisisManagement.Domain;

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

            //var x = global::Domain.Objects.xxx;

            var p = new DomainObjects.Person();

            var e = new DomainObjects.Employee();

            var f = new DomainObjects.Family();

            Console.WriteLine(f.Members.First().birthDate.ToShortDateString());



            var x = new VA.CrisisManagement.HrApplicationFacade.CompoundFilter<VA.CrisisManagement.HrApplicationFacade.EmployeeFindFilter>()
            {
                one = new VA.CrisisManagement.HrApplicationFacade.EmployeeFindFilter(),
                two = new VA.CrisisManagement.HrApplicationFacade.EmployeeFindFilter(),
                comb = VA.CrisisManagement.HrApplicationFacade.FilterCombinator.and
            };

        }
    }
}
