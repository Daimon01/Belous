using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Npgsql;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            NpgsqlConnection connect = new NpgsqlConnection("User ID=postgres; Password = 123; Host = localhost; Port = 5432;" +
                "Database = human_resources;");
            connect.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select country_id, country_name from countries", connect);
            Application application = new Application();
            Workbook book = application.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet wsh = book.Worksheets[1];
            wsh.Cells[1, 1] = "ID country";
            wsh.Cells[1, 2] = "Name country";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wsh.Cells[x, 1] = reader.GetString(0);
                wsh.Cells[x, 2] = reader.GetString(1);
                x++;
            }
            book.SaveAs("C:\\temp\\book1.xls", XlFileFormat.xlWorkbookNormal);
            book.Close();
            application.Quit();

        }
    }
}
