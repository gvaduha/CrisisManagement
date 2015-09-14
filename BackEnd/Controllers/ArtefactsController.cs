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
     * We don't use or check roomId on this backend site
     * */
    public class ArtifactsController : ApiController
    {
        private static DomainObjects.Artifact dummy = new DomainObjects.Artifact();

        /// <summary>
        /// Return all Artifacts from room
        /// </summary>
        [Route("api/rooms/{roomId}/Artifacts/{fake:bool?}")]
        public IEnumerable<DomainObjects.Artifact> Get(string roomId, bool fake)
        {
            return dummy.getArtifacts(roomId);
        }

        /// <summary>
        /// Return Artifact by id from room
        /// Really we don't check the room at backend
        /// </summary>
        [Route("api/Artifacts/{docId}")]
        public DomainObjects.Artifact Get(string docId)
        {
            return dummy.getArtifact(docId);
        }

        /// <summary>
        /// Create new Artifact in room
        /// </summary>
        [Route("api/rooms/{roomId}/Artifacts")]
        public void Post(string roomId, [FromBody]string value)
        {
            //TODO: Create new Artifact and return it id
        }

        /// <summary>
        /// Delete Artifact by id from room
        /// Really we don't check the room at backend
        /// </summary>
        [Route("api/Artifacts/{docId}")]
        public void Delete(string docId)
        {
            //TODO: delete Artifact (mark deleted)
        }
    }
}
