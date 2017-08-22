using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEF2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TestDBEntities db = new TestDBEntities())
            {
                //AGREGAR
                //Universidad u = new Universidad();
                //u.Nombre = "APEC";
                //db.Universads.Add(u);

                //ELIMINAR
                //var uni = db.Universidads.FirstOrDefault(x => x.Nombre == "APEC");
                //db.Universidads.Remove(uni);
                //db.SaveChanges();

                //actualizar
                var uni = db.Universidads.FirstOrDefault(x => x.Id == 1);
                //db.Universidads.Remove(uni);
                uni.Nombre = "Universidad Autonoma de Santo Domingo";
                db.SaveChanges();
            }
            
        }
    }
}
