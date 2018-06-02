using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-28 Exporting some data to Excel
    /// </summary>
    class Program
    {
        static void DisplayInExcel(IEnumerable<dynamic> entities)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;

            excelApp.Workbooks.Add();

            dynamic workSheet = excelApp.ActiveSheet;

            workSheet.Cells[1, "A"] = "Header A";
            workSheet.Cells[1, "B"] = "Header B";

            var row = 1;
            foreach(var entity in entities)
            {
                row++;
                workSheet.Cells[row, "A"] = entity.ColumnA;
                workSheet.Cells[row, "B"] = entity.ColumnB;
            }

            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
        }



        static void Main(string[] args)
        {
            var entities = new List<dynamic>
            {
                new
                {
                    ColumnA = 1,
                    ColumnB = "Foo"
                },
                new
                {
                    ColumnA = 2,
                    ColumnB = "Bar"
                }
            };

            DisplayInExcel(entities);

        }
    }
}
