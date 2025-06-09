using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerhalingIdee_Domain.Persistence;

namespace HerhalingIdee_Domain.Business
{
    public class Controller
    {
        private Persistence.Controller _persistController;
        public Controller()
        {
            _persistController = new Persistence.Controller();
        }
        public void addIdee(IdeePersoon idee)
        {
            _persistController.addIdee(idee);
        }
        public List<IdeePersoon> getIdeeList()
        {

            return _persistController.GetIdeeFromDB();
        }
        public void DeleteIdeeFromDB(IdeePersoon idee)
        {
            
            _persistController.DeleteIdeeFromDB(idee);

        }
    }
}
