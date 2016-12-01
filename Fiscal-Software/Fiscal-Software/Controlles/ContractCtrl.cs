using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controlles
{
    class ContractCtrl
    {
        public static void AddContract(Contract contract)
        {


            using (var ctx = new FiscalSoftware())
            {
                ctx.Contracts.Add(contract);
                ctx.SaveChanges();
            }
        }
        public static void UpdateContract(int id, Contract contract)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.Contracts.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (original != null)
                {
                    original.Name = contract.Name;
                    original.Duration = contract.Duration;
                    original.MP3 = contract.MP3;
                    original.Price = contract.Price;
                    original.PaymentTo = contract.PaymentTo;
                    original.Programming = contract.Programming;
                    original.ProgrammingArticul = contract.ProgrammingArticul;
                    original.Rabota = contract.Rabota;
                    original.SpareParts = contract.SpareParts;
                    original.SpareModuls = contract.SpareModuls;
                    original.Protect = contract.Protect;
                    ctx.SaveChanges();
                }
            }
        }
        public static Contract GetContractById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var contract = ctx.Contracts.Where(b => b.ID == id)
                    .FirstOrDefault();
                return contract;
            }
        }
        public static void DeleteContractById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var contract = ctx.Contracts.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (contract != null)
                {
                    ctx.Contracts.Remove(contract);
                }


                ctx.SaveChanges();


            }
        }


        public static Contract[] GetAllContracts()
        {
            using (var ctx = new FiscalSoftware())
            {
                var contract = ctx.Set<Contract>().ToArray();
                return contract;
            }
        }
    }
}
