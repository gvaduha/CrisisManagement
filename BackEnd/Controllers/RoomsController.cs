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
     * Controller to edit documents
     * We don't use or check roomid on this backend site
     * */
    public class RoomsController : ApiController
    {
        private static DomainObjects.Document dummy = new DomainObjects.Document();

        // GET api/documents/roomid
        /// <summary>
        /// Return all documents from room
        /// </summary>
        public IEnumerable<DomainObjects.Document> Get(string roomid)
        {
            return dummy.getDocuments(roomid);
        }

        // GET api/documents/roomid/docid
        /// <summary>
        /// Return document by id from room
        /// Really we don't check the room at backend
        /// </summary>
        public DomainObjects.Document Get(string roomid, string docid)
        {
            return dummy.getDocument(docid);
        }

        // POST api/documents/roomid
        /// <summary>
        /// Create new document in room
        /// </summary>
        public void Post(string roomid, [FromBody]string value)
        {
            //TODO: Create new document and return it id
        }

        // DELETE api/documents/roomid/docid
        /// <summary>
        /// Delete document by id from room
        /// Really we don't check the room at backend
        /// </summary>
        public void Delete(string roomid, string docid)
        {
            //TODO: delete document (mark deleted)
        }
    }
}
