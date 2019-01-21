using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NortwindDataContext db = new NortwindDataContext();
            #region Insert
            //Employee e = new Employee();
            //e.FirstName = "deniz";
            //e.LastName = "tanrıverdi";
            //e.City = "istanbul";
            //e.Country = "turkey";
            //e.HomePhone = "798643133";
            //e.Address="xyz";
            //db.Employees.InsertOnSubmit(e);
            //db.SubmitChanges();
            #endregion

            #region Update

            //Employee e = db.Employees.FirstOrDefault(I => I.FirstName == "deniz");
            //e.Title = "qwers";
            //db.SubmitChanges();

            #endregion

            #region Delete
            //Employee e = db.Employees.FirstOrDefault(I => I.FirstName == "deniz");
            //db.Employees.DeleteOnSubmit(e);
            //db.SubmitChanges();
            #endregion
            Console.ReadLine();
        }
    }
}
