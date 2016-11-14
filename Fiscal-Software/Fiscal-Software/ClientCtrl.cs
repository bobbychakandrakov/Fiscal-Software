using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software
{
    class ClientCtrl
    {
        public static void AddClient(string Name, string TDD, string Mol, string MolTown, string MolAddress, string Dn, string Bulstat, string FDTown, DateTime FDDate, string FDNumber, string Town, string Address, string Telephone, string Fax, string Email, string Web, string MolTelephone, string MolEgn)
        {
            Client client = new Client();
            client.Name = Name;
            client.TDD = TDD;
            client.Mol = Mol;
            client.MolTown = MolTown;
            client.MolAddress = MolAddress;
            client.DN = Dn;
            client.Bulstat = Bulstat;
            client.FDDate = FDDate;
            client.FDNumber = FDNumber;
            client.FDTown = FDTown;
            client.Town = Town;
            client.Address = Address;
            client.Telephone = Telephone;
            client.Fax = Fax;
            client.Email = Email;
            client.Web = Web;
            client.MolEGN = MolEgn;
            client.MolTown = MolTown;


            using (var ctx = new FiscalSoftware())
            {
                ctx.Clients.Add(client);
                ctx.SaveChanges();
                Console.WriteLine("client added");
            }
        }
        public static void UpdateClient(int id, string Name, string TDD, string Mol, string MolTown, string MolAddress, string Dn, string Bulstat, string FDTown, DateTime FDDate, string FDNumber, string Town, string Address, string Telephone, string Fax, string Email, string Web, string MolTelephone, string MolEgn)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.Clients.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (original != null)
                {

                    original.Name = Name;
                    original.TDD = TDD;
                    original.Mol = Mol;
                    original.MolTown = MolTown;
                    original.MolAddress = MolAddress;
                    original.DN = Dn;
                    original.Bulstat = Bulstat;
                    original.FDDate = FDDate;
                    original.FDNumber = FDNumber;
                    original.FDTown = FDTown;
                    original.Town = Town;
                    original.Address = Address;
                    original.Telephone = Telephone;
                    original.Fax = Fax;
                    original.Email = Email;
                    original.Web = Web;
                    original.MolEGN = MolEgn;
                    original.MolTown = MolTown;
                    ctx.SaveChanges();
                    Console.WriteLine("Client updated!");
                }
                else
                {
                    Console.WriteLine("cannot find Client");
                }
            }
        }

        public static Client GetClient(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var client = ctx.Clients.Where(b => b.ID == id)
                    .FirstOrDefault();


                return client;
            }
        }

        public static void DeleteClient(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var client = ctx.Clients.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (client != null)
                {
                    ctx.Clients.Remove(client);
                    ctx.SaveChanges();
                    Console.WriteLine("Client was deleted!");
                }
            }
        }
    }
}
