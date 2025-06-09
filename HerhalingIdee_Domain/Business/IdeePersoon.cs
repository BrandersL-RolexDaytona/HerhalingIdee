using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerhalingIdee_Domain.Business
{
    public class IdeePersoon
    {
        public int Id{ get; set; }
        public string NaamPersoon { get; set; }
        public string TelPersoon { get; set; }
        public string Idee { get; set; }
        public IdeePersoon()
        {
            Id = 0;
            NaamPersoon = string.Empty;
            TelPersoon = string.Empty;
            Idee = string.Empty;
        }
        public IdeePersoon(string naamPersoon, string telPersoon, string idee)
        {
            Id = 0;
            NaamPersoon = naamPersoon;
            TelPersoon = telPersoon;
            Idee = idee;
        }
        public IdeePersoon(int id,string naamPersoon, string telPersoon, string idee)
        {
            Id = id;
            NaamPersoon = naamPersoon;
            TelPersoon = telPersoon;
            Idee = idee;
        }
    }
}
