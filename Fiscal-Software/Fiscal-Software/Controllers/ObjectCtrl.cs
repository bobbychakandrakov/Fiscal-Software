using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controllers
{
    public class ObjectCtrl
    {
        public static void AddObject(Objects objects)
        {

            using (var ctx = new FiscalSoftware())
            {
                ctx.Objects.Add(objects);
                ctx.SaveChanges();
                
            }

        }

        public static void UpdateObject(int id, Objects objects)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.Objects.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (original != null)
                {
                    original.Type = objects.Type;
                    original.Activity = objects.Activity;
                    original.Ekatte = objects.Ekatte;
                    original.Town = objects.Town;
                    original.Address = objects.Address;
                    original.Telephone = objects.Telephone;
                    original.TDD = objects.TDD;
                    original.Mol = objects.Mol;
                    original.MolTown= objects.MolTown;
                    original.MolAddress = objects.MolAddress;
                    original.MolTelephone = objects.MolTelephone;
                    original.ClientId = objects.ClientId;

                    ctx.SaveChanges();
                }
            }
        }

        public static Objects GetObjectById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var objects = ctx.Objects.Where(b => b.ID == id)
                    .FirstOrDefault();
                return objects;
            }
        }

        public static void DeleteObjectById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var objects = ctx.Objects.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (objects != null)
                {
                    ctx.Objects.Remove(objects);
                }


                ctx.SaveChanges();


            }
        }

        public static Objects[] GetAllObjects()
        {
            using (var ctx = new FiscalSoftware())
            {
                var objects = ctx.Set<Objects>().ToArray();
                return objects;
            }
        }

        public static Objects[] GetObjectsForClient(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var objects = ctx.Objects.Where(i => i.ClientId == id).ToArray();
                return objects;
            }
        }
    }
}
