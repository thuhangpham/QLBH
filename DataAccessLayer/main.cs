using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    static class main
    {
        static void Main()
        {
            Database.SetInitializer(new Initializer());
            using(var context = new Context())
            {
                context.Database.CreateIfNotExists();
            }
        }
    }
}
