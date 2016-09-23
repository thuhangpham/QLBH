using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public static class Linq2DataTable
    {
        /// <summary>
        /// Numbered
        /// </summary>
        /// <param name="dtb">DataTable</param>
        /// <param name="numbered">Numbered if true else not numbered</param>
        ///  So thu tu
        //public static void Numbered(this DataTable dtb, bool numbered = true)
        //{
        //    if (numbered)
        //    {
        //        dtb.Columns.Add("No.");
        //        for (int i = 0; i < dtb.Rows.Count; i++)
        //            dtb.Rows[i].SetField("No.", i + 1); // numbered
        //    }

        //    dtb.AcceptChanges();
        //}

        public static DataTable ToDataTable<T>(this IEnumerable<T> data,
                    bool numbered = true, string tableName = "Table_Name")
        {
            var res =Linq2Table((IEnumerable<T>)data, tableName);
           // res.Numbered(numbered);
            return res;
        }


        public static DataTable Linq2Table<T>(IEnumerable<T> list, string tableName)
        {
            try
            {
                var tb = new DataTable(tableName);
                PropertyInfo[] pro = null;
                if (list == null) return tb;

                foreach (T rec in list)
                {
                    if (pro == null)
                    {
                        pro = ((Type)rec.GetType()).GetProperties();
                        foreach (var pi in pro)
                        {
                            Type colType = pi.PropertyType;
                            // Phai kiem tra IsGenericType truoc khi 
                            // goi GetGenericTypeDefinition
                            if ((colType.IsGenericType) &&
                                (colType.GetGenericTypeDefinition()
                                == typeof(Nullable<>)))
                                // GetGenericArguments Tra ve 1 mang Type
                                colType = colType.GetGenericArguments()[0];
                            tb.Columns.Add(new DataColumn(pi.Name, colType));
                        }
                    }
                    DataRow dr = tb.NewRow();
                    foreach (var pi in pro)
                        dr[pi.Name] = pi.GetValue(rec, null) ?? DBNull.Value;
                    tb.Rows.Add(dr);
                }
                return tb;
            }
            catch { return null; }
        }
    }
}
