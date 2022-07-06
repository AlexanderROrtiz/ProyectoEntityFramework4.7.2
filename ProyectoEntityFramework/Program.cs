using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ProyectoEntityFrameworkEntities db = new ProyectoEntityFrameworkEntities())
            {
                //CRUD con Entity Framework en consola

                ////insertando un nuevo registro add
                //Tbl_Personas personas = new Tbl_Personas();
                //personas.nombre = "Hector";
                //personas.edad = 22;
                //personas.idSexo = 1;

                //db.Tbl_Personas.Add(personas);
                //db.SaveChanges();

                //Editar registro
                //Tbl_Personas personas = db.Tbl_Personas.Where(d => d.nombre == "ana").First();
                //personas.edad = 30;
                //db.Entry(personas).State = System.Data.Entity.EntityState.Modified;
                //db.SaveChanges();

                //Eliminar registro
                //Tbl_Personas personas = db.Tbl_Personas.Find(2);
                //db.Tbl_Personas.Remove(personas);
                //db.SaveChanges();

                //listar registros 
                var lst = db.Tbl_Personas;
                foreach (var pers in lst)
                {
                    Console.WriteLine(pers.nombre);
                }

               
            }

        }
    }
}
