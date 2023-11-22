using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;

using System.Collections.Generic;
using System.IO;

namespace X_Toko.Data
{
    class Excel
    {
        private Files file = new Files();
        private Pesan pesan = new Pesan();
        private Properti properti = new Properti();

        public bool SaveExcel(string nama_file)
        {
            string nama = string.Concat(nama_file, ".xlsx");

            try
            {
                if (file.DeleteFile(nama))
                {
                    List<Properti> list = properti.Read(file.DatabasePath);
                    using (IWorkbook workbook = new XSSFWorkbook())
                    {
                        CreateSheetFromList(workbook, list, nama_file);
                        using (FileStream sw = File.Create(nama))
                        {
                            workbook.Write(sw);
                        }
                    }
                    pesan.IsiPesan = $"File Excel berhasil dibuat dengan nama {nama}";
                    return true;
                }
                else
                {
                    // File tidak dapat dihapus, mungkin karena tidak ada
                    pesan.IsiPesan = $"Gagal menghapus file {nama}";
                    return false;
                }
            }
            catch (System.Exception ex)
            {
                pesan.IsiPesan = $"Gagal membuat file Excel: {ex.Message}";
                return false;
            }
        }

        private static void CreateSheetFromList(IWorkbook workbook, List<Properti> list, string nama_file)
        {
            var NameSheet = string.IsNullOrEmpty(nama_file) ? $"Sheet 1" : nama_file;
            var sheet = (XSSFSheet)workbook.CreateSheet(NameSheet);

            var properties = typeof(Properti).GetProperties();
            var columnCount = properties.Length;
            var rowCount = list.Count;

            // add column headers
            var row = sheet.CreateRow(0);
            for (var columnIndex = 0; columnIndex < columnCount; columnIndex++)
            {
                var property = properties[columnIndex];
                row.CreateCell(columnIndex).SetCellValue(property.Name);
            }

            // add data rows
            for (var rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                var item = list[rowIndex];
                var sheetRow = sheet.CreateRow(rowIndex + 1);
                for (var columnIndex = 0; columnIndex < columnCount; columnIndex++)
                {
                    var property = properties[columnIndex];
                    sheetRow.CreateCell(columnIndex).SetCellValue(property.GetValue(item)?.ToString());
                }
            }

            // format the cell range as a table
            XSSFTable xssfTable = sheet.CreateTable();
            CT_Table ctTable = xssfTable.GetCTTable();
            AreaReference myDataRange = new AreaReference(new CellReference(0, 0), new CellReference(rowCount, columnCount - 1));
            var tableId = uint.Parse("1");
            ctTable.@ref = myDataRange.FormatAsString();
            ctTable.id = tableId;
            ctTable.name = $"Table{tableId}";
            ctTable.displayName = $"Table{tableId}";
            ctTable.tableStyleInfo = new CT_TableStyleInfo
            {
                name = "TableStyleMedium2", // TableStyleMedium2 is one of XSSFBuiltinTableStyle
                showRowStripes = true
            };
            ctTable.tableColumns = new CT_TableColumns
            {
                tableColumn = new List<CT_TableColumn>()
            };
            for (var columnIndex = 0; columnIndex < columnCount; columnIndex++)
            {
                var property = properties[columnIndex];
                var colId = uint.Parse((columnIndex + 1).ToString());
                ctTable.tableColumns.tableColumn.Add(new CT_TableColumn() { id = colId, name = property.Name });
            }

            // turn on filtering
            ctTable.autoFilter = new CT_AutoFilter
            {
                @ref = myDataRange.FormatAsString()
            };

            // auto-size columns
            for (var columnIndex = 0; columnIndex < columnCount; columnIndex++)
            {
                sheet.AutoSizeColumn(columnIndex);
            }
            for (var columnIndex = 0; columnIndex < columnCount; columnIndex++)
            {
                // make room for the filter button and add a bit more
                var colWidth = sheet.GetColumnWidth(columnIndex);
                sheet.SetColumnWidth(columnIndex, colWidth + 1500);
            }
        }
    }
}
