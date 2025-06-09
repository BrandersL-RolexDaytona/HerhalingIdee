using HerhalingIdee_Domain.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerhalingIdee_Domain.Persistence
{
    internal class Controller
    {
        public void addIdee(IdeePersoon idee)
        {
            IdeePersoonMapper mapper = new IdeePersoonMapper();
            mapper.addIdeeToDb(idee);
        }
        public List<IdeePersoon> GetIdeeFromDB()
        {
            IdeePersoonMapper mapper = new IdeePersoonMapper();
            return mapper.GetIdeeFromDB();
        }
        public void DeleteIdeeFromDB(IdeePersoon idee)
        {
            IdeePersoonMapper mapper = new IdeePersoonMapper();
            mapper.DeleteIdeeFromDB(idee);

        }

    }
}
