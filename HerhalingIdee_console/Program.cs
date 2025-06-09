using HerhalingIdee_Domain.Business;

namespace HerhalingIdee_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller control = new Controller();

            Console.WriteLine("Hoi, geef hieronder je idee door samen met je contactgegevens. We werken er dan aan!");
            Console.Write("Naam: ");
            string naam = Console.ReadLine();
            Console.Write("Telefoonnummer: ");
            string tel = Console.ReadLine();
            Console.Write("Idee: ");
            string ideeTekst = Console.ReadLine();

            IdeePersoon nieuwIdee = new IdeePersoon(naam, tel, ideeTekst);

            control.addIdee(nieuwIdee);

            Console.WriteLine("Het idee is doorgegeven!");

        }
    }
}
