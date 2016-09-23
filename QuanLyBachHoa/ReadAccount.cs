using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace QuanLyBachHoa
{
     public class ReadAccount
    {
         public string [] ReadFile(string filePath)
         {
             return File.ReadAllLines(filePath);
         }
    }
}
