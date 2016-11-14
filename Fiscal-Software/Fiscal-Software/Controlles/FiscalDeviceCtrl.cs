using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controllers
{
    class FiscalDeviceCtrl
    {
        public static void AddFiscalDevice(string Model, int CertificateN, string Type, string Manufacturer, DateTime StartDate, Decimal Price, int Waranty, string BulstatManufacturer)
        {
            FiscalDevice fiscalDevice = new FiscalDevice();
            fiscalDevice.Model = Model;
            fiscalDevice.CertificateN = CertificateN;
            fiscalDevice.Type = Type;
            fiscalDevice.Manufacturer = Manufacturer;
            fiscalDevice.StartDate = StartDate;
            fiscalDevice.Price = Price;
            fiscalDevice.Warranty = Waranty;
            fiscalDevice.BulstatManufacturer = BulstatManufacturer;
            using (var ctx = new FiscalSoftware())
            {
                ctx.FiscalDevices.Add(fiscalDevice);
                ctx.SaveChanges();
                Console.WriteLine("FiscalDevice added");
            }
        }
        public static FiscalDevice GetFiscalDevice(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var fiscalDevice = ctx.FiscalDevices.Where(b => b.ID == id)
                    .FirstOrDefault();


                return fiscalDevice;
            }
        }
        public static void DeleteFiscalDevice(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var fiscalDevice = ctx.FiscalDevices.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (fiscalDevice != null)
                {
                    ctx.FiscalDevices.Remove(fiscalDevice);
                    ctx.SaveChanges();
                    Console.WriteLine("FiscalDevice was deleted!");
                }
            }
        }

        public static void UpdateFiscalDevice(int id, string Model, int CertificateN, string Type, string Manufacturer, DateTime StartDate, Decimal Price, int Waranty, string BulstatManufacturer)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.FiscalDevices.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (original != null)
                {

                    original.Model = Model;
                    original.CertificateN = CertificateN;
                    original.Type = Type;
                    original.Manufacturer = Manufacturer;
                    original.StartDate = StartDate;
                    original.Price = Price;
                    original.Warranty = Waranty;
                    original.BulstatManufacturer = BulstatManufacturer;
                    ctx.SaveChanges();
                    Console.WriteLine("FiscalDevice updated!");
                }
                else
                {
                    Console.WriteLine("cannot find FiscalDevice");
                }
            }
        }
    }
}
