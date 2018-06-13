using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace Joonas_Praktika3
{
    public class ExcelPage
    {
        public Application xlApp { get; set; }
        public Workbook xlWorkbook { get; set; }
        public Worksheet xlWorksheet { get; set; }
    }
}