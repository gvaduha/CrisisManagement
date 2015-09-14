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
     * Controller to edit Artifacts
     * */
    public class LockArtifactController : ApiController
    {
        private static DomainObjects.Artifact dummy = new DomainObjects.Artifact();
        private static DomainObjects.CrisisTeamMember memberdummy = new DomainObjects.CrisisTeamMember();

        [Route("api/{crisisId}/rooms/{roomId}/Artifacts/{docId}/lock/emploeeId")]
        public DomainObjects.Artifact Get(string crisisId, string roomId, string docId, string emploeeId)
        {
            var member = new DomainObjects.CrisisTeamMember();
            return dummy.getAndLockArtifact(docId, emploeeId);
        }

        [Route("api/{crisisId}/rooms/{roomId}/Artifacts/{docId}/unlock")]
        public void Put(string crisisId, string roomId, string docId, [FromBody]string value)
        {
            //HACK: a) Get info from JSON request body
            //      b) check lock
            //      c) dummy.putAndUnlockArtifact();
            //      d) Check if it's saved and return appropriate HTTP code
        }
    }
}
