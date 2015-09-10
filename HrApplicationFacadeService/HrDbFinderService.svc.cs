using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using VA.CrisisManagement.Domain;
using VA.CrisisManagement.HrApplicationFacade;

namespace VA.CrisisManagement.HrApplicationFacadeService
{
    public class HrDbFinderService : IHrDbFinderService
    {
        private static PeopleFinder _peopleFinder = new PeopleFinder();
        private static EmployeeFinder _employeeFinder = new EmployeeFinder();

        public IEnumerable<DomainObjects.Employee> findEmployee(IFindFilter filter)
        {
            return _employeeFinder.findEmployee(filter);
        }

        public IEnumerable<DomainObjects.Person> findPerson(IFindFilter filter)
        {
            return _peopleFinder.findPerson(filter);
        }
    }
}
