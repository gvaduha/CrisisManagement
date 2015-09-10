using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * LDAP facade interface and classes to authenticate and search LDAP
 * Should use LINQ to LDAP https://linqtoldap.codeplex.com/
 * this library is mature and provide expressive to query LDAP
 * */
namespace VA.CrisisManagement.LdapFacade
{
    //TODO: Implement LDAP mapping 
    public class User
    {}

    public interface ILdapAuthenticator
    {
        bool Authenticate(string domain, string user, string pass);
    }

    public interface ILdapFinder
    {
        IEnumerable<User> getUsers();

        // Other get and find methods depending on System requirements
    }

    // Mock class
    public class LdapFacade : ILdapAuthenticator, ILdapFinder
    {
        public LdapFacade(string ldapPath) { }

        //HACK: Return true
        public bool Authenticate(string domain, string user, string pass) { return true; }

        public IEnumerable<User> getUsers() { throw new NotImplementedException(); }
    }
}
