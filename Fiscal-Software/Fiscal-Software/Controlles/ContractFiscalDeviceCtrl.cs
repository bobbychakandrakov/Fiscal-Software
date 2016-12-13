using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controlles
{
    class ContractFiscalDeviceCtrl
    {
        public static void AddContractFiscalDevice(ContractFiscalDevices cfd)
        {


            using (var ctx = new FiscalSoftware())
            {
                ctx.ContractFiscalDevices.Add(cfd);
                ctx.SaveChanges();
            }
        }

        public static void UpdateControlFiscalDevice(int id, ContractFiscalDevices cfd)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.ContractFiscalDevices.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (original != null)
                {

                    original.ContractType = cfd.ContractType;
                    original.AutomaticNumbering = cfd.AutomaticNumbering;
                    original.ContractN = cfd.ContractN;
                    original.DateFrom = cfd.DateFrom;
                    original.DateTo = cfd.DateTo;
                    original.SumMonth = cfd.SumMonth;
                    original.Sum = cfd.Sum;
                    original.Valid = cfd.Valid;
                    original.Notes = cfd.Notes;
                    ctx.SaveChanges();


                }
                else
                {
                    Console.WriteLine("cannot find ContractFiscalDevice");
                }
            }
        }


        public static ContractFiscalDevices GetContractFiscalDevice(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var cfd = ctx.ContractFiscalDevices.Where(b => b.ID == id)
                    .FirstOrDefault();


                return cfd;
            }
        }

        public static void DeleteContractFiscalDevice(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var cfd = ctx.ContractFiscalDevices.Where(b => b.ID == id)
                    .FirstOrDefault();

               

                if (cfd != null)
                {

                     ctx.ContractFiscalDevices.Remove(cfd);
                    ctx.SaveChanges();
                }
                

               
               
            }
        }
        public static ContractFiscalDevices[] GetAllContractFiscalDevices(int objId)
        {
            using (var ctx = new FiscalSoftware())
            {
                var cfd = ctx.ContractFiscalDevices.Where(e=>e.ObjectId==objId).ToArray();
                return cfd;
            }
        }

    }
}
