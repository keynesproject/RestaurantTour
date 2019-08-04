using RestaurantTour.Model.DataAccessObject;
using RestaurantTour.View.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantTour.View.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();                         
        }

        private bool Login()
        {
            //檢查有無輸入操作者代碼;//
            if(string.IsNullOrEmpty(tbUser.Text))
            {
                MessageBoxEx.Show(this, "請輸入帳號!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUser.Focus();
                return false;
            }

            //檢查有無輸入密碼;//
            if (string.IsNullOrEmpty(tbPW.Text))
            {
                MessageBoxEx.Show(this, "請輸入密碼!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPW.Focus();
                return false;
            }

            string User = tbUser.Text.ToLower();
            string PW = tbPW.Text.ToLower();

            if (User.Equals("admin") == false)
            {
                MessageBoxEx.Show(this, "帳號錯誤!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUser.Focus();
                return false;
            }

            if (PW.Equals("myp") == false)
            {
                MessageBoxEx.Show(this, "密碼錯誤!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPW.Focus();
                return false;
            }

            MessageBoxEx.Show(this, "登入成功!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //表示登入成功，要關閉視窗;//
            DialogResult = DialogResult.OK;

            return true;
        }

        private void BtnLogin_MouseUp(object sender, MouseEventArgs e)
        {
            Login();
        }

        private void TbPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Login();
            }
        }

        private void PbLogoMYP_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://www.unical.com.tw/");
            }
            catch
            {
                //表示沒有預設的開啟網址的應用程式，不予動作;//
            }
        }

        private void BtnClose_MouseUp(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
