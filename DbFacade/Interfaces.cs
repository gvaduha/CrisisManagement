using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VA.CrisisManagement.Domain;

namespace VA.CrisisManagement.DbFacade
{
    // Builder pattern for WHERE clause
    public interface IFindFilter
    {
        string buildFilter();
    }

    public enum FilterCompositor
    {
        and
        , or
    }

    public class CompoundFilter<TFilter> : IFindFilter
    {
        public TFilter one;
        public TFilter two;
        public FilterCompositor comp;

        public string buildFilter() { throw new NotImplementedException(); }
    }

    //TODO: Implement NOT filters


    public interface ICrisisDatabase
    {
        T findObject<T>(IFindFilter filter);
    }

}
