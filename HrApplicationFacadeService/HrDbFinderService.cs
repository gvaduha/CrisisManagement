using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using VA.CrisisManagement.Domain;
using VA.CrisisManagement.DbFacade;
using VA.CrisisManagement.HrApplicationFacade;

namespace VA.CrisisManagement.HrApplicationFacadeService
{
    [ServiceContract]
    public interface IHrDbFinderService
    {
        [OperationContract]
        IEnumerable<DomainObjects.Employee> findEmployee(IFindFilter filter);

        [OperationContract]
        IEnumerable<DomainObjects.Person> findPerson(IFindFilter filter);
    }
}
