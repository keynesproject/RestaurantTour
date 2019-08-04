namespace RestaurantTour.View.Forms
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogoMYP = new System.Windows.Forms.PictureBox();
            this.tlpLogin = new System.Windows.Forms.TableLayoutPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lblSplit1 = new System.Windows.Forms.Label();
            this.tlpBtn = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tlpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMYP)).BeginInit();
            this.tlpLogin.SuspendLayout();
            this.tlpBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.pbLogoMYP, 0, 0);
            this.tlpBase.Controls.Add(this.tlpLogin, 0, 2);
            this.tlpBase.Controls.Add(this.lblSplit1, 0, 1);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 3;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.Size = new System.Drawing.Size(398, 330);
            this.tlpBase.TabIndex = 0;
            // 
            // pbLogoMYP
            // 
            this.pbLogoMYP.BackgroundImage = global::RestaurantTour.Properties.Resources.logo;
            this.pbLogoMYP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogoMYP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogoMYP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogoMYP.Location = new System.Drawing.Point(3, 3);
            this.pbLogoMYP.Name = "pbLogoMYP";
            this.pbLogoMYP.Size = new System.Drawing.Size(392, 126);
            this.pbLogoMYP.TabIndex = 0;
            this.pbLogoMYP.TabStop = false;
            this.pbLogoMYP.Click += new System.EventHandler(this.PbLogoMYP_Click);
            // 
            // tlpLogin
            // 
            this.tlpLogin.ColumnCount = 4;
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpLogin.Controls.Add(this.lblUser, 1, 1);
            this.tlpLogin.Controls.Add(this.lblPW, 1, 2);
            this.tlpLogin.Controls.Add(this.tbPW, 2, 2);
            this.tlpLogin.Controls.Add(this.tbUser, 2, 1);
            this.tlpLogin.Controls.Add(this.tlpBtn, 2, 3);
            this.tlpLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLogin.Location = new System.Drawing.Point(3, 138);
            this.tlpLogin.Name = "tlpLogin";
            this.tlpLogin.RowCount = 4;
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tlpLogin.Size = new System.Drawing.Size(392, 189);
            this.tlpLogin.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(49, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 55);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "帳    號";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPW.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblPW.Location = new System.Drawing.Point(49, 77);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(58, 55);
            this.lblPW.TabIndex = 2;
            this.lblPW.Text = "密    碼";
            this.lblPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPW
            // 
            this.tbPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPW.Font = new System.Drawing.Font("Arial", 11F);
            this.tbPW.Location = new System.Drawing.Point(113, 87);
            this.tbPW.Margin = new System.Windows.Forms.Padding(3, 10, 3, 4);
            this.tbPW.MaxLength = 128;
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(228, 24);
            this.tbPW.TabIndex = 1;
            this.tbPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPW_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(48, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登  入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnLogin_MouseUp);
            // 
            // tbUser
            // 
            this.tbUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUser.Font = new System.Drawing.Font("Arial", 11F);
            this.tbUser.Location = new System.Drawing.Point(113, 32);
            this.tbUser.Margin = new System.Windows.Forms.Padding(3, 10, 3, 4);
            this.tbUser.MaxLength = 128;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(228, 24);
            this.tbUser.TabIndex = 0;
            // 
            // lblSplit1
            // 
            this.lblSplit1.AutoSize = true;
            this.lblSplit1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSplit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSplit1.Location = new System.Drawing.Point(3, 132);
            this.lblSplit1.Name = "lblSplit1";
            this.lblSplit1.Size = new System.Drawing.Size(392, 3);
            this.lblSplit1.TabIndex = 2;
            // 
            // tlpBtn
            // 
            this.tlpBtn.AutoSize = true;
            this.tlpBtn.ColumnCount = 3;
            this.tlpBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpBtn.Controls.Add(this.btnLogin, 1, 0);
            this.tlpBtn.Controls.Add(this.btnClose, 2, 0);
            this.tlpBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBtn.Location = new System.Drawing.Point(113, 135);
            this.tlpBtn.Name = "tlpBtn";
            this.tlpBtn.RowCount = 1;
            this.tlpBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBtn.Size = new System.Drawing.Size(228, 51);
            this.tlpBtn.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(139, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 45);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "離  開";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnClose_MouseUp);
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(398, 330);
            this.Controls.Add(this.tlpBase);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "刷卡資料整合系統登入";
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMYP)).EndInit();
            this.tlpLogin.ResumeLayout(false);
            this.tlpLogin.PerformLayout();
            this.tlpBtn.ResumeLayout(false);
            this.tlpBtn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.TableLayoutPanel tlpLogin;
        private System.Windows.Forms.Label lblSplit1;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.PictureBox pbLogoMYP;
        private System.Windows.Forms.TableLayoutPanel tlpBtn;
        private System.Windows.Forms.Button btnClose;
    }
}