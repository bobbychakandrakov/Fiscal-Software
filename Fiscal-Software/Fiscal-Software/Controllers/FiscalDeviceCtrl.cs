using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controllers
{
    class FiscalDeviceCtrl
    {
        public static void AddFiscalDevice(FiscalDevice fiscalDevice)
        {
            /*
            FiscalDevice fiscalDevice = new FiscalDevice();
            fiscalDevice.Model = Model;
            fiscalDevice.CertificateN = CertificateN;
            fiscalDevice.Type = Type;
            fiscalDevice.Manufacturer = Manufacturer;
            fiscalDevice.StartDate = StartDate;
            fiscalDevice.Price = Price;
            fiscalDevice.Warranty = Waranty;
            fiscalDevice.BulstatManufacturer = BulstatManufacturer;
            */
            using (var ctx = new FiscalSoftware())
            {
                ctx.FiscalDevices.Add(fiscalDevice);
                ctx.SaveChanges();
            }
        }

        public static FiscalDevice[] GetAllFiscalDevices()
        {
            using (var ctx = new FiscalSoftware())
            {
                var fiscalDivices = ctx.Set<FiscalDevice>().ToArray();
                return fiscalDivices;
            }
        }

        public static string GetBulstat(string man)
        {
            using (var ctx = new FiscalSoftware())
            {
                var fiscalDivice = ctx.FiscalDevices.Where(fd => fd.Manufacturer == man).FirstOrDefault();
                if (fiscalDivice != null)
                {
                    return fiscalDivice.BulstatManufacturer;
                }
                return string.Empty;
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

        public static void UpdateFiscalDevice(int id, FiscalDevice fiscalDevice)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.FiscalDevices.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (original != null)
                {
                    original.Model = fiscalDevice.Model;
                    original.CertificateN = fiscalDevice.CertificateN;
                    original.Type = fiscalDevice.Type;
                    original.Manufacturer = fiscalDevice.Manufacturer;
                    original.StartDate = fiscalDevice.StartDate;
                    original.Price = fiscalDevice.Price;
                    original.Warranty = fiscalDevice.Warranty;
                    original.BulstatManufacturer = fiscalDevice.BulstatManufacturer;
                    ctx.SaveChanges();
                }
            }
        }
        public static FiscalDevice[] GetAllFiscalDevice()
        {
            using (var ctx = new FiscalSoftware())
            {
                var fiscalDevice = ctx.Set<FiscalDevice>().ToArray();
                return fiscalDevice;
            }
        }
    }
}
