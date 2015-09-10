using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VA.CrisisManagement.Domain;
using VA.CrisisManagement.DbFacade;

/*
 * Facade to existing HR system
 * "Peope" in this context means Employee or Family member i.e. all how
 * organization cares of
 * Filter structrures should be extended with properties System will search with
 * */
namespace VA.CrisisManagement.HrApplicationFacade
{
    //TODO: review content
    public class PeopleFindFilter : IFindFilter
    {
        public string name;
        public DateTime birthDate;

        public string buildFilter() { throw new NotImplementedException(); }
    }

    //TODO: review content
    public class EmployeeFindFilter : PeopleFindFilter
    {
        public string position;

        new public string buildFilter() { throw new NotImplementedException(); }
    }


    /// <summary>
    /// Finds Employees in HR Database
    /// </summary>
    public interface IEmployeeFinder
    {
        IEnumerable<DomainObjects.Employee> findEmployee(IFindFilter filter);
    }

    /// <summary>
    /// Finds Employees or their family members in HR Database
    /// </summary>
    public interface IPeopleFinder
    {
        IEnumerable<DomainObjects.Person> findPerson(IFindFilter filter);
    }

    // Ad-hoc interface to HR database. Should not be implemented unless
    // we need to get unstructured information
    interface IFreeFormFinder
    {
        IEnumerable<Object> findHrApplicationObject(IFindFilter filter);
    }
}
