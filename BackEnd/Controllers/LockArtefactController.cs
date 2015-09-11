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
    /*
     * Controller to edit Artefacts
     * */
    public class LockArtefactController : ApiController
    {
        private static DomainObjects.Artefact dummy = new DomainObjects.Artefact();
        private static DomainObjects.CrisisTeamMember memberdummy = new DomainObjects.CrisisTeamMember();

        [Route("api/{crisisId}/rooms/{roomId}/Artefacts/{docId}/lock/emploeeId")]
        public DomainObjects.Artefact Get(string crisisId, string roomId, string docId, string emploeeId)
        {
            var member = new DomainObjects.CrisisTeamMember();
            return dummy.getAndLockArtefact(docId, emploeeId);
        }

        [Route("api/{crisisId}/rooms/{roomId}/Artefacts/{docId}/unlock")]
        public void Put(string crisisId, string roomId, string docId, [FromBody]string value)
        {
            //HACK: a) Get info from JSON request body
            //      b) check lock
            //      c) dummy.putAndUnlockArtefact();
            //      d) Check if it's saved and return appropriate HTTP code
        }
    }
}
