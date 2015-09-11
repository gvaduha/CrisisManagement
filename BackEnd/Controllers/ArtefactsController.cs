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
     * We don't use or check roomId on this backend site
     * */
    public class ArtefactsController : ApiController
    {
        private static DomainObjects.Artefact dummy = new DomainObjects.Artefact();

        /// <summary>
        /// Return all Artefacts from room
        /// </summary>
        [Route("api/rooms/{roomId}/Artefacts/{fake:bool?}")]
        public IEnumerable<DomainObjects.Artefact> Get(string roomId, bool fake)
        {
            return dummy.getArtefacts(roomId);
        }

        /// <summary>
        /// Return Artefact by id from room
        /// Really we don't check the room at backend
        /// </summary>
        [Route("api/Artefacts/{docId}")]
        public DomainObjects.Artefact Get(string docId)
        {
            return dummy.getArtefact(docId);
        }

        /// <summary>
        /// Create new Artefact in room
        /// </summary>
        [Route("api/rooms/{roomId}/Artefacts")]
        public void Post(string roomId, [FromBody]string value)
        {
            //TODO: Create new Artefact and return it id
        }

        /// <summary>
        /// Delete Artefact by id from room
        /// Really we don't check the room at backend
        /// </summary>
        [Route("api/Artefacts/{docId}")]
        public void Delete(string docId)
        {
            //TODO: delete Artefact (mark deleted)
        }
    }
}
