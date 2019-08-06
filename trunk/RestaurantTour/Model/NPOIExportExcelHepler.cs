using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using NPOI.HSSF.Util;
using NPOI.HSSF.UserModel;
using NPOI.SS.Util;
using NPOI.SS.UserModel;
using System.IO;

namespace RestaurantTour.Model
{
    public class ExportExcel
    {
        public void GridToExcel(string fileName, DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 2003格式|*.xls";
            sfd.FileName = fileName + DateTime.Now.ToString("_yyyyMMdd");
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            HSSFWorkbook wb = new HSSFWorkbook();
            HSSFSheet sheet = (HSSFSheet)wb.CreateSheet(fileName);
            HSSFRow headRow = (HSSFRow)sheet.CreateRow(0);
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                HSSFCell headCell = (HSSFCell)headRow.CreateCell(i, CellType.String);
                headCell.SetCellValue(dgv.Columns[i].HeaderText);
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                HSSFRow row = (HSSFRow)sheet.CreateRow(i + 1);
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    HSSFCell cell = (HSSFCell)row.CreateCell(j);
                    if (dgv.Rows[i].Cells[j].Value == null)
                    {
                        cell.SetCellType(CellType.Blank);
                    }
                    else
                    {
                        if (dgv.Rows[i].Cells[j].ValueType.FullName.Contains("System.Int32"))
                        {
                            cell.SetCellValue(Convert.ToInt32(dgv.Rows[i].Cells[j].Value));
                        }
                        else if (dgv.Rows[i].Cells[j].ValueType.FullName.Contains("System.String"))
                        {
                            cell.SetCellValue(dgv.Rows[i].Cells[j].Value.ToString());
                        }
                        else if (dgv.Rows[i].Cells[j].ValueType.FullName.Contains("System.Single"))
                        {
                            cell.SetCellValue(Convert.ToSingle(dgv.Rows[i].Cells[j].Value));
                        }
                        else if (dgv.Rows[i].Cells[j].ValueType.FullName.Contains("System.Double"))
                        {
                            cell.SetCellValue(Convert.ToDouble(dgv.Rows[i].Cells[j].Value));
                        }
                        else if (dgv.Rows[i].Cells[j].ValueType.FullName.Contains("System.Decimal"))
                        {
                            cell.SetCellValue(Convert.ToDouble(dgv.Rows[i].Cells[j].Value));
                        }
                        else if (dgv.Rows[i].Cells[j].ValueType.FullName.Contains("System.DateTime"))
                        {
                            cell.SetCellValue(Convert.ToDateTime(dgv.Rows[i].Cells[j].Value).ToString("yyyy-MM-dd"));
                        }
                        else if(dgv.Rows[i].Cells[j].ValueType.FullName.Contains("System.Object"))
                        {
                            cell.SetCellValue(Convert.ToString(dgv.Rows[i].Cells[j].Value));
                        }
                    }
                }

            }
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                sheet.AutoSizeColumn(i);
            }
            using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
            {
                wb.Write(fs);
            }
            MessageBox.Show("匯出成功！", "匯出提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    /*
    class NPOIExportExcelHepler
    {
        ///<summary>
        ///私有成員
        ///</summary>
        private HSSFWorkbook n_objBook;
        private HSSFSheet n_objSheet;
        private HSSFRow n_objHeadRow;
        private HSSFDataFormat n_objDataformat;
        private HSSFCellStyle n_objCellStyle;

        ///<summary>
        ///資料表到Excel
        ///</summary>
        ///<param name="fileName">儲存檔案的檔名</param>
        ///<param name="dgv">DataGridView</param>
        ///<param name="InforDataTable">DataTable</param>
        public void DataGridViewToExcel(string fileName, DataGridView dgv, DataTable InforDataTable)
        {
            //不匯出空表
            if (dgv.Rows.Count == 0)
            {
                return;
            }

            SaveFileDialog saveFlie = new SaveFileDialog();
            saveFlie.DefaultExt = "xls";
            saveFlie.Filter = "Excel 2007格式 | *.xls";
            saveFlie.FileName = fileName + DateTime.Now.ToString("yyyyMMddHHmmss");


            //是否儲存，否，返回
            if (saveFlie.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            //Excel操作物件
            n_objBook = new HSSFWorkbook();
            n_objSheet = (HSSFSheet)n_objBook.CreateSheet(fileName);
            n_objHeadRow = (HSSFRow)n_objSheet.CreateRow(0);
            n_objDataformat = (HSSFDataFormat)n_objBook.CreateDataFormat();
            n_objCellStyle = (HSSFCellStyle)n_objBook.CreateCellStyle();


            //表頭
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                HSSFCell headCell = (HSSFCell)n_objHeadRow.CreateCell(i, CellType.String);
                headCell.SetCellValue(dgv.Columns[i].HeaderText);
            }



            //資料寫入
            for (int i = 0; i < dgv.Rows.Count; i++)
            {

                HSSFRow n_Row = (HSSFRow)n_objSheet.CreateRow(i+1);

                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    HSSFCell cell = (HSSFCell)n_Row.CreateCell(j);
                    string valueType = InforDataTable.Rows[i][j].GetType().ToString();
                    string value = InforDataTable.Rows[i][j].ToString();

                    //指定資料的型別並賦值，採用TryParse進行強制轉換
                    switch (valueType)
                    {

                        case "System.String":
                           n_Row.CreateCell(j).SetCellValue(value);
                            break;

                        case "System.DateTime":
                            System.DateTime dateValue;
                            System.DateTime.TryParse(value, out dateValue);
                            //MessageBox.Show("i=" i.ToString() "j=" j.ToString() "value=" value.ToString());
                            n_Row.CreateCell(j).SetCellValue(dateValue);
                            n_objCellStyle.DataFormat = n_objDataformat.GetFormat("yyyy / MM / dd HH: mm:ss");//設定日期型別資料列的單元格格式
                            n_Row.Cells[j].CellStyle = n_objCellStyle;

                            break;

                        case "System.Boolean":
                            bool boolValue = false;
                            bool.TryParse(value, out boolValue);
                            n_Row.CreateCell(j).SetCellValue(boolValue);
                            break;


                        case "System.Int16":
                        case "System.Int32":
                        case "System.Int64":
                        case "System.Byte":

                            int intValue = 0;
                            int.TryParse(value, out intValue);
                            n_Row.CreateCell(j).SetCellValue(intValue);

                            break;

                        case "System.Decimal":
                        case "System.Double":
                            double doubleValue = 0;
                            double.TryParse(value, out doubleValue);
                            n_Row.CreateCell(j).SetCellValue(doubleValue);
                            break;

                        case"System.DBNull":
                           n_Row.CreateCell(j).SetCellValue("");
                            break;

                        default:
                            n_Row.CreateCell(j).SetCellValue("");
                            break;
                    }
                }
            }



            //設定各列自動適應單元個字元長度
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                n_objSheet.AutoSizeColumn(i);
            }
                       
            //寫入操作異常檢測，檢測檔案是否被佔用
            try
            {
                using (FileStream fs = new FileStream(saveFlie.FileName, FileMode.Create))
                {
                    n_objBook.Write(fs);//寫入
                    fs.Close();//關閉資料流
                    GC.Collect();//垃圾回收（銷燬資料流）
                }
                MessageBox.Show("匯出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                ///異常報出有待改善
                MessageBox.Show("檔案" + fileName + "正在被另一程式佔用", "錯誤提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }
    }
    */
}
