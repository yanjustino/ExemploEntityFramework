using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacinas.DataAccess;
using Vacinas.DataModel;
using Vacinas.DataModel.Contracts;

namespace Vacinas.Application
{
    public class ServiceLocator
    {
        public static ICRUD<doenca> CrudDoenca
        {
            get { return new CRUD<doenca>(); }
        }
    }
}
