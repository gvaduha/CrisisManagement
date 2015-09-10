using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VA.CrisisManagement.Domain;

namespace VA.CrisisManagement.DbFacade
{
    public static class DbMock
    {
        //// Mock implementations. Unfortunately C# wouldn't accept it. Cannot infer the types?
        //public static IEnumerable<T> getEmployees(this T obj, IFindFilter filter)
        //{
        //    yield return obj;
        //}


        //TODO: Make abstraction over HrApplicationFacadeService to get emploeeys
        /// <summary>
        /// Return employees from HR Application by given filter
        /// </summary>
        public static IEnumerable<DomainObjects.Employee> getEmployees(this DomainObjects.Employee obj, IFindFilter filter)
        {
            yield return obj;
        }

        /// <summary>
        /// Return document by roomid
        /// </summary>
        public static IEnumerable<DomainObjects.Document> getDocuments(this DomainObjects.Document obj, string roomid)
        {
            yield return obj;
        }

        /// <summary>
        /// Return document by id
        /// </summary>
        public static DomainObjects.Document getDocument(this DomainObjects.Document obj, string id)
        {
            return obj;
        }

        /// <summary>
        /// Set lock flag in the DB on returned document to enable exclusive edit
        /// </summary>
        public static DomainObjects.Document getAndLockDocument(this DomainObjects.Document obj, string id, DomainObjects.CrisisTeamMember lockHolder)
        {
            return obj;
        }

        /// <summary>
        /// Set lock flag in the DB on returned document to enable exclusive edit
        /// </summary>
        public static bool putAndUnlockDocument(this DomainObjects.Document obj, string id, DomainObjects.CrisisTeamMember lockHolder)
        {
            return true;
        }
    }
}
