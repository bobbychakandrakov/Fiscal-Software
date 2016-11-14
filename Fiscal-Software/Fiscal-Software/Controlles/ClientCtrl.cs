using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controllers
{
    class ClientCtrl
    {
        public static void AddClient(Client client)
        {
          

            using (var ctx = new FiscalSoftware())
            {
                ctx.Clients.Add(client);
                ctx.SaveChanges();
            }
        }
        public static void UpdateClient(int id,Client client)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.Clients.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (original != null)
                {

                    original.Name = client.Name;
                    original.TDD = client.TDD;
                    original.Mol = client.Mol;
                    original.MolTown = client.MolTown;
                    original.MolAddress = client.MolAddress;
                    original.DN = client.DN;
                    original.Bulstat =client. Bulstat;
                    original.FDDate = client.FDDate;
                    original.FDNumber = client.FDNumber;
                    original.FDTown = client.FDTown;
                    original.Town = client.Town;
                    original.Address = client.Address;
                    original.Telephone = client.Telephone;
                    original.Fax =client. Fax;
                    original.Email = client.Email;
                    original.Web = client.Web;
                    original.MolEGN = client.MolEGN;
                    original.MolTown = client.MolTown;
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
        public static Client[] GetAllClients()
        {
            using (var ctx = new FiscalSoftware())
            {
                var client = ctx.Set<Client>().ToArray();
                return client;
            }
        }
    }
}
