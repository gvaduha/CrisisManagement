using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Mvc;

using VA.CrisisManagement.Domain;
using VA.CrisisManagement.DbFacade;

namespace BackEnd.Controllers
{
    public class VictimsController : ApiController
    {
        private static DomainObjects.Crisis dummycris = new DomainObjects.Crisis();
        private static DomainObjects.Victim dummy = new DomainObjects.Victim();

        /// <summary>
        /// Return all victims for crisis
        /// </summary>
        [Route("api/{crisisId}/victims")]
        public IEnumerable<DomainObjects.Victim> Get(string crisisId)
        {
            return dummy.getVictims(crisisId);
        }

        /// <summary>
        /// Return victim by id from crisis
        /// </summary>
        [Route("api/{crisisId}/victims/{victimId}")]
        public DomainObjects.Victim Get(string crisisId, string victimId)
        {
            return dummy.getVictim(victimId);
        }

        //TODO: Other operations
        // POST api/...
        // PUT api/...
        // DELETE api/...
    }
}
