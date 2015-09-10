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
    public class LockDocumentController : ApiController
    {
        private static DomainObjects.Document dummy = new DomainObjects.Document();
        private static DomainObjects.CrisisTeamMember memberdummy = new DomainObjects.CrisisTeamMember();

        // GET api/lockdocument/docid/emploeeid
        public DomainObjects.Document Get(string docid, string empid)
        {
            var member = new DomainObjects.CrisisTeamMember();
            //HACK: member is hardcoded
            //member = memberdummy.getMember(empid);
            return dummy.getAndLockDocument(docid, member);
        }

        // PUT api/lockdocument/roomid/docid/emploeeid
        public void Put(string docid, [FromBody]string value)
        {
            //HACK: a) Get info from JSON request body
            //      b) get Document and CrisisTeamMember
            //      c) dummy.putAndUnlockDocument();
            //      d) Check if it's saved and return appropriate HTTP code
        }
    }
}
