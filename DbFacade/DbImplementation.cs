﻿using System;
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
        /// Return Artifact by roomId
        /// </summary>
        public static IEnumerable<DomainObjects.Artifact> getArtifacts(this DomainObjects.Artifact obj, string roomId)
        {
            yield return obj;
        }

        /// <summary>
        /// Return Artifact by id
        /// </summary>
        public static DomainObjects.Artifact getArtifact(this DomainObjects.Artifact obj, string docId)
        {
            return obj;
        }

        /// <summary>
        /// Set lock flag in the DB on returned Artifact to enable exclusive edit
        /// </summary>
        public static DomainObjects.Artifact getAndLockArtifact(this DomainObjects.Artifact obj, string docId, string lockerEmploeeId)
        {
            return obj;
        }

        /// <summary>
        /// Put to DB and unlock exclusively edited doc
        /// </summary>
        public static bool putAndUnlockArtifact(this DomainObjects.Artifact obj, string docId)
        {
            return true;
        }


        /// <summary>
        /// Return all Crisis victims
        /// </summary>
        public static IEnumerable<DomainObjects.Victim> getVictims(this DomainObjects.Victim obj, string crisisId)
        {
            yield return obj;
        }

        /// <summary>
        /// Return victim by id
        /// </summary>
        public static DomainObjects.Victim getVictim(this DomainObjects.Victim obj, string victimId)
        {
            return obj;
        }

    }
}
