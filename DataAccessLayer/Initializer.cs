using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
   public class Initializer: DropCreateDatabaseIfModelChanges<Context>
    {
       //protected override void Seed(Context context)
       //{
       //    //context.ChucVus.Add(new ChucVu
       //    //    {
       //    //        TenChucVu = "Quan Ly",
       //    //    });
       //}
    }
}
