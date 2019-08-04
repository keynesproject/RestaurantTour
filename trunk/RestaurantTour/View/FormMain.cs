using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using RestaurantTour.Model.DataAccessObject;
using RestaurantTour.View.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantTour.View
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DaoSQL.Instance.GetOldestDate();
            dtpEnd.Value = DateTime.Today;

            ReloadData();
        }

        /// <summary>
        /// 關於按鍵按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            FormAbout About = new FormAbout();
            About.ShowDialog();
        }

        /// <summary>
        /// 主選單離開按鈕按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiClose_Click(object sender, EventArgs e)
        {
            DaoSQL.Instance.CloseDatabase();

            this.Close();
        }

        private void DgvDevice_DragDrop(object sender, DragEventArgs e)
        {
            string[] FilesPath = (string[])e.Data.GetData(DataFormats.FileDrop);

            bool isShowImportErrorMsg = true;

            this.Cursor = Cursors.AppStarting;
            
            foreach (string file in FilesPath)
            {
                if (CheckXls(file) == true) //檢查是否為EXCEL檔;//
                {
                    if (CheckPersonnelXlsData(file) == true)
                    {
                        if( ReadFromExcelFile(file) == true )                            
                            MessageBoxEx.Show(this, string.Format("{0} 資料匯入成功。", file), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isShowImportErrorMsg = false;
                    }
                    else
                    {
                        MessageBoxEx.Show(this, string.Format("{0} 資料內容錯誤，沒包含必要欄位資訊!", file), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        isShowImportErrorMsg = false;
                    }
                }
                else if(CheckTxtFormat(file) == true)  //檢查TXT的資料內容正不正確;//
                {
                    MessageBoxEx.Show(this, string.Format("{0} 資料匯入成功。", file), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isShowImportErrorMsg = false;
                }
            }  

            if(isShowImportErrorMsg == true)
            {
                MessageBoxEx.Show(this, "不支援的檔案類型或格式!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ReloadData();
            }

            this.Cursor = Cursors.Default;
        }

        private void DgvDevice_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        /// <summary>
        /// 檢查是否為Excel檔
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns></returns>
        private bool CheckXls(string FilePath)
        {
            //default sFileName is not Exe or Dll File
            bool isExcelFile = false;  
            System.IO.FileStream fs = new System.IO.FileStream(FilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.IO.BinaryReader r = new System.IO.BinaryReader(fs);
            string bx = "";
            byte buffer;
            try
            {
                buffer = r.ReadByte();
                bx = buffer.ToString();
                buffer = r.ReadByte();
                bx += buffer.ToString();
                buffer = r.ReadByte();
                bx += buffer.ToString();
                buffer = r.ReadByte();
                bx += buffer.ToString();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);                
            }
            r.Close();
            fs.Close();

            if (bx == "20820717224")
            {
                isExcelFile = true;
            }
            Console.WriteLine(bx);
            return isExcelFile;
        }

        /// <summary>
        /// 檢查Excel是否有包含必要欄位
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private bool CheckPersonnelXlsData(string filePath)
        {
            IWorkbook wk = null;
            string extension = System.IO.Path.GetExtension(filePath);

            FileStream fs = File.OpenRead(filePath);
            if (extension.Equals(".xls"))
            {
                //把xls文件中的數據寫入wk中
                wk = new HSSFWorkbook(fs);
            }
            else
            {
                //把xlsx文件中的數據寫入wk中
                wk = new XSSFWorkbook(fs);
            }
            fs.Close();

            //讀取當前表數據
            ISheet sheet = wk.GetSheetAt(0);

            //讀取當前行數據,LastRowNum是當前表的總行數-1（注意）
            IRow row = sheet.GetRow(0);

            //取得指定標頭的行數;//
            List<string> CaptureColumnName = new List<string> { "指定序號", "工號", "中文名稱", "英文名稱", "卡號", "別名", "語音", "行動電話" };
            List<int> CaptureNo = new List<int>();
            for (int j = 0; j < row.LastCellNum; j++)
            {
                ICell value = row.GetCell(j);
                if (value == null)
                    continue;

                if (CaptureColumnName.Contains(value.ToString()))
                {
                    CaptureNo.Add(j);
                }
            }

            if (CaptureNo.Count != CaptureColumnName.Count)
                return false;

            return true;
        }

        /// <summary>
        /// 讀取excel文件
        /// </summary>
        /// <param name="filePath">文件路徑</param>
        private bool ReadFromExcelFile(string filePath)
        {
            IWorkbook wk = null;
            string extension = System.IO.Path.GetExtension(filePath);
            try
            {
                FileStream fs = File.OpenRead(filePath);
                if (extension.Equals(".xls"))
                {
                    //把xls文件中的數據寫入wk中
                    wk = new HSSFWorkbook(fs);
                }
                else
                {
                    //把xlsx文件中的數據寫入wk中
                    wk = new XSSFWorkbook(fs);
                }
                fs.Close();
                
                //讀取當前表數據
                ISheet sheet = wk.GetSheetAt(0);

                //讀取當前行數據,LastRowNum是當前表的總行數-1（注意）
                IRow row = sheet.GetRow(0);  

                //取得指定標頭的行數;//
                List<string> CaptureColumnName = new List<string> { "指定序號", "工號", "中文名稱", "英文名稱", "卡號", "別名", "語音", "通訊電話", "行動電話" };
                List<int> CaptureNo = new List<int>();
                for (int j = 0; j < row.LastCellNum; j++)
                {
                    ICell value = row.GetCell(j);
                    if (value == null)
                        continue;

                    if(CaptureColumnName.Contains(value.ToString()))
                    {
                        CaptureNo.Add(j);
                    }
                }

                List<PersonnelContent> Personnel = new List<PersonnelContent>();
                string text = string.Empty;
                for (int i = 1; i <= sheet.LastRowNum; i++)
                {
                    //讀取當前行數據
                    row = sheet.GetRow(i);  
                    if (row != null)
                    {
                        PersonnelContent content = new PersonnelContent();

                        //LastCellNum 是當前行的總列數
                        for (int j = 0; j < row.LastCellNum; j++)
                        {
                            if (CaptureNo.Contains(j) == false)
                                continue;

                            ICell value = row.GetCell(j);
                            if (value == null)
                                continue;

                            int ContentIndex = CaptureNo.FindIndex(a=>a.Equals(j));

                            switch(ContentIndex)
                            {
                                case 0:
                                    content.Key = value.ToString();
                                    break;
                                case 1:
                                    content.JobNumber = value.ToString();
                                    break;
                                case 2:
                                    content.ChineseName = value.ToString();
                                    break;
                                case 3:
                                    content.EnglicshName = value.ToString();
                                    break;
                                case 4:
                                    content.CardNumber = value.ToString();
                                    break;
                                case 5:
                                    content.Alias = value.ToString();
                                    break;
                                case 6:
                                    content.Voice = value.ToString();
                                    break;
                                case 7:
                                    content.TEL = value.ToString();
                                    break;
                                case 8:
                                    content.Phone = value.ToString();
                                    break;
                            }
                        }

                        Personnel.Add(content);
                    }
                }

                DaoErrMsg err = DaoSQL.Instance.UpdatePersonnel(Personnel);
                if (err.isError == true)                
                    return false;
            }
            catch (Exception e)
            {
                MessageBoxEx.Show(this, string.Format("{0}匯入錯誤，{1}", filePath, e.Message), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }
        
        /// <summary>
        /// 檢查TXT內容格式是否正確
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns></returns>
        private bool CheckTxtFormat(string FilePath)
        {
            bool isCorrectData = true;
            string strline;

            List<Attendance> attendance = new List<Attendance>();

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(FilePath);
            while ((strline = file.ReadLine()) != null)
            {
                if(strline.Length != 24)
                {
                    isCorrectData = false;
                    break;
                }

                char[] separators = { ',' };
                string[] param = strline.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                if (param.Count() != 3)
                {
                    isCorrectData = false;
                    break;
                }
                else if(param[0].Length != 10
                    || param[1].Length != 8
                    || param[2].Length != 4 )
                {
                    isCorrectData = false;
                    break;
                }

                attendance.Add(new Attendance(param[0], DateTime.ParseExact(param[1] + param[2], "yyyyMMddHHmm", System.Globalization.CultureInfo.CurrentCulture)));
            }
            file.Close();

            if (isCorrectData == true
                && attendance.Count > 0)
            {
                DaoSQL.Instance.UpdateAttendance(attendance);

                dtpStart.Value = DaoSQL.Instance.GetOldestDate();
                dtpEnd.Value = DateTime.Today;
            }

            return isCorrectData;
        }

        private void ReloadData()
        {
            if(rdDisplayAll.Checked == true)
            {
                this.dgvDevice.DataSource = DaoSQL.Instance.GetAll(dtpStart.Value, dtpEnd.Value, tbName.Text, tbPhone.Text, tbCardNo.Text);
            }
            else
            {
                this.dgvDevice.DataSource = DaoSQL.Instance.GetCount(dtpStart.Value, dtpEnd.Value, tbName.Text, tbPhone.Text, tbCardNo.Text);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void TsmiClearData_Click(object sender, EventArgs e)
        {
            bool hadAttInfoDel = false;
            FormDeleteAttendance FormDA = new FormDeleteAttendance();
            DialogResult Ret = FormDA.ShowDialog();
            if (Ret != DialogResult.OK)
                return;

            //進行資料刪除;//
            this.Cursor = Cursors.AppStarting;

            DaoSQL.Instance.DeleteData();

            MessageBoxEx.Show(this, "匯入刷卡資料已全數刪除", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today;
            ReloadData();

            this.Cursor = Cursors.Default;
        }
    }
}
