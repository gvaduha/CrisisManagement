using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VA.CrisisManagement.Domain;

namespace VA.CrisisManagement.HrApplicationFacade
{
    /// <summary>
    /// Finds Employees in HR Database
    /// </summary>
    public class EmployeeFinder : IEmployeeFinder
    {
        public IEnumerable<DomainObjects.Employee> findEmployee(IFindFilter filter)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Finds Employees or their family members in HR Database
    /// </summary>
    public class PeopleFinder : IPeopleFinder
    {
        public IEnumerable<DomainObjects.Person> findPerson(IFindFilter filter)
        {
            throw new NotImplementedException();
        }
    }
}
