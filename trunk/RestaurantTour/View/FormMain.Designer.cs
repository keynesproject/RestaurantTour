namespace RestaurantTour.View
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.tlpSearchDateBase = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbCardNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbDisplay = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdDisplayCount = new System.Windows.Forms.RadioButton();
            this.rdDisplayAll = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tlpDateSearch = new System.Windows.Forms.TableLayoutPanel();
            this.llbSearchEnd = new System.Windows.Forms.LinkLabel();
            this.lblDotSearchStart = new System.Windows.Forms.Label();
            this.lblDotSearchEnd = new System.Windows.Forms.Label();
            this.llbSearchStart = new System.Windows.Forms.LinkLabel();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msMain.SuspendLayout();
            this.tlpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.tlpSearchDateBase.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbDisplay.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tlpDateSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSetting,
            this.tsmiHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msMain.Size = new System.Drawing.Size(834, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiSetting
            // 
            this.tsmiSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClearData,
            this.toolStripSeparator1,
            this.tsmiClose});
            this.tsmiSetting.Name = "tsmiSetting";
            this.tsmiSetting.Size = new System.Drawing.Size(44, 20);
            this.tsmiSetting.Text = "設定";
            // 
            // tsmiClearData
            // 
            this.tsmiClearData.Name = "tsmiClearData";
            this.tsmiClearData.Size = new System.Drawing.Size(180, 22);
            this.tsmiClearData.Text = "清除資料 (&C)";
            this.tsmiClearData.Click += new System.EventHandler(this.TsmiClearData_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(180, 22);
            this.tsmiClose.Text = "結束 (&X)";
            this.tsmiClose.Click += new System.EventHandler(this.TsmiClose_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 20);
            this.tsmiHelp.Text = "說明";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(180, 22);
            this.tsmiAbout.Text = "關於 (&A)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tlpBase
            // 
            this.tlpBase.AutoSize = true;
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.dgvDevice, 0, 1);
            this.tlpBase.Controls.Add(this.tlpSearchDateBase, 0, 0);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 24);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 2;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Size = new System.Drawing.Size(834, 592);
            this.tlpBase.TabIndex = 1;
            // 
            // dgvDevice
            // 
            this.dgvDevice.AllowDrop = true;
            this.dgvDevice.AllowUserToAddRows = false;
            this.dgvDevice.AllowUserToDeleteRows = false;
            this.dgvDevice.AllowUserToResizeRows = false;
            this.dgvDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDevice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnName,
            this.columnPhone,
            this.columnCardNo,
            this.columnDate,
            this.columnCount});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevice.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevice.Location = new System.Drawing.Point(3, 123);
            this.dgvDevice.MultiSelect = false;
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.ReadOnly = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDevice.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDevice.RowHeadersVisible = false;
            this.dgvDevice.RowTemplate.Height = 24;
            this.dgvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevice.Size = new System.Drawing.Size(828, 466);
            this.dgvDevice.TabIndex = 1;
            this.dgvDevice.TabStop = false;
            this.dgvDevice.DragDrop += new System.Windows.Forms.DragEventHandler(this.DgvDevice_DragDrop);
            this.dgvDevice.DragEnter += new System.Windows.Forms.DragEventHandler(this.DgvDevice_DragEnter);
            // 
            // tlpSearchDateBase
            // 
            this.tlpSearchDateBase.AutoSize = true;
            this.tlpSearchDateBase.ColumnCount = 4;
            this.tlpSearchDateBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSearchDateBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSearchDateBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSearchDateBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchDateBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSearchDateBase.Controls.Add(this.groupBox1, 2, 0);
            this.tlpSearchDateBase.Controls.Add(this.gbDisplay, 0, 0);
            this.tlpSearchDateBase.Controls.Add(this.groupBox2, 1, 0);
            this.tlpSearchDateBase.Controls.Add(this.btnSearch, 3, 0);
            this.tlpSearchDateBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchDateBase.Location = new System.Drawing.Point(0, 0);
            this.tlpSearchDateBase.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSearchDateBase.Name = "tlpSearchDateBase";
            this.tlpSearchDateBase.RowCount = 1;
            this.tlpSearchDateBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSearchDateBase.Size = new System.Drawing.Size(834, 120);
            this.tlpSearchDateBase.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(423, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.groupBox1.Size = new System.Drawing.Size(282, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "進階搜尋";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbName, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbPhone, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbCardNo, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(270, 93);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "˙";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label3.Location = new System.Drawing.Point(23, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "卡號";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbName.Location = new System.Drawing.Point(101, 3);
            this.tbName.MaxLength = 64;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(166, 25);
            this.tbName.TabIndex = 0;
            // 
            // tbPhone
            // 
            this.tbPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPhone.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPhone.Location = new System.Drawing.Point(101, 34);
            this.tbPhone.MaxLength = 64;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(166, 25);
            this.tbPhone.TabIndex = 1;
            // 
            // tbCardNo
            // 
            this.tbCardNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCardNo.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbCardNo.Location = new System.Drawing.Point(101, 65);
            this.tbCardNo.MaxLength = 64;
            this.tbCardNo.Name = "tbCardNo";
            this.tbCardNo.Size = new System.Drawing.Size(166, 25);
            this.tbCardNo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label1.Location = new System.Drawing.Point(23, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "姓名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "行動電話";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "˙";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "˙";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbDisplay
            // 
            this.gbDisplay.AutoSize = true;
            this.gbDisplay.Controls.Add(this.tableLayoutPanel1);
            this.gbDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDisplay.Location = new System.Drawing.Point(3, 3);
            this.gbDisplay.Name = "gbDisplay";
            this.gbDisplay.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.gbDisplay.Size = new System.Drawing.Size(108, 114);
            this.gbDisplay.TabIndex = 0;
            this.gbDisplay.TabStop = false;
            this.gbDisplay.Text = "顯示類型";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.rdDisplayCount, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rdDisplayAll, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(96, 93);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rdDisplayCount
            // 
            this.rdDisplayCount.AutoSize = true;
            this.rdDisplayCount.Checked = true;
            this.rdDisplayCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdDisplayCount.Font = new System.Drawing.Font("Arial", 11.25F);
            this.rdDisplayCount.Location = new System.Drawing.Point(3, 30);
            this.rdDisplayCount.Name = "rdDisplayCount";
            this.rdDisplayCount.Size = new System.Drawing.Size(90, 21);
            this.rdDisplayCount.TabIndex = 1;
            this.rdDisplayCount.TabStop = true;
            this.rdDisplayCount.Text = "依照次數";
            this.rdDisplayCount.UseVisualStyleBackColor = true;
            // 
            // rdDisplayAll
            // 
            this.rdDisplayAll.AutoSize = true;
            this.rdDisplayAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdDisplayAll.Font = new System.Drawing.Font("Arial", 11.25F);
            this.rdDisplayAll.Location = new System.Drawing.Point(3, 3);
            this.rdDisplayAll.Name = "rdDisplayAll";
            this.rdDisplayAll.Size = new System.Drawing.Size(90, 21);
            this.rdDisplayAll.TabIndex = 0;
            this.rdDisplayAll.Text = "全部";
            this.rdDisplayAll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tlpDateSearch);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(117, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.groupBox2.Size = new System.Drawing.Size(300, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "統計日期區間";
            // 
            // tlpDateSearch
            // 
            this.tlpDateSearch.AutoSize = true;
            this.tlpDateSearch.ColumnCount = 3;
            this.tlpDateSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDateSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDateSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDateSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDateSearch.Controls.Add(this.llbSearchEnd, 1, 1);
            this.tlpDateSearch.Controls.Add(this.lblDotSearchStart, 0, 0);
            this.tlpDateSearch.Controls.Add(this.lblDotSearchEnd, 0, 1);
            this.tlpDateSearch.Controls.Add(this.llbSearchStart, 1, 0);
            this.tlpDateSearch.Controls.Add(this.dtpStart, 2, 0);
            this.tlpDateSearch.Controls.Add(this.dtpEnd, 2, 1);
            this.tlpDateSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDateSearch.Location = new System.Drawing.Point(6, 18);
            this.tlpDateSearch.Name = "tlpDateSearch";
            this.tlpDateSearch.RowCount = 2;
            this.tlpDateSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDateSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDateSearch.Size = new System.Drawing.Size(288, 93);
            this.tlpDateSearch.TabIndex = 0;
            // 
            // llbSearchEnd
            // 
            this.llbSearchEnd.AutoSize = true;
            this.llbSearchEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbSearchEnd.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.llbSearchEnd.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.llbSearchEnd.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llbSearchEnd.LinkColor = System.Drawing.Color.Black;
            this.llbSearchEnd.Location = new System.Drawing.Point(23, 49);
            this.llbSearchEnd.Margin = new System.Windows.Forms.Padding(3);
            this.llbSearchEnd.Name = "llbSearchEnd";
            this.llbSearchEnd.Size = new System.Drawing.Size(76, 41);
            this.llbSearchEnd.TabIndex = 0;
            this.llbSearchEnd.Text = "結束日期";
            this.llbSearchEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDotSearchStart
            // 
            this.lblDotSearchStart.AutoSize = true;
            this.lblDotSearchStart.BackColor = System.Drawing.Color.Transparent;
            this.lblDotSearchStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotSearchStart.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDotSearchStart.ForeColor = System.Drawing.Color.Black;
            this.lblDotSearchStart.Location = new System.Drawing.Point(3, 0);
            this.lblDotSearchStart.Name = "lblDotSearchStart";
            this.lblDotSearchStart.Size = new System.Drawing.Size(14, 46);
            this.lblDotSearchStart.TabIndex = 0;
            this.lblDotSearchStart.Text = "˙";
            this.lblDotSearchStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDotSearchEnd
            // 
            this.lblDotSearchEnd.AutoSize = true;
            this.lblDotSearchEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblDotSearchEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotSearchEnd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDotSearchEnd.ForeColor = System.Drawing.Color.Black;
            this.lblDotSearchEnd.Location = new System.Drawing.Point(3, 46);
            this.lblDotSearchEnd.Name = "lblDotSearchEnd";
            this.lblDotSearchEnd.Size = new System.Drawing.Size(14, 47);
            this.lblDotSearchEnd.TabIndex = 0;
            this.lblDotSearchEnd.Text = "˙";
            this.lblDotSearchEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llbSearchStart
            // 
            this.llbSearchStart.AutoSize = true;
            this.llbSearchStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbSearchStart.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.llbSearchStart.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.llbSearchStart.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llbSearchStart.LinkColor = System.Drawing.Color.Black;
            this.llbSearchStart.Location = new System.Drawing.Point(23, 3);
            this.llbSearchStart.Margin = new System.Windows.Forms.Padding(3);
            this.llbSearchStart.Name = "llbSearchStart";
            this.llbSearchStart.Size = new System.Drawing.Size(76, 40);
            this.llbSearchStart.TabIndex = 0;
            this.llbSearchStart.Text = "起始日期";
            this.llbSearchStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpStart
            // 
            this.dtpStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpStart.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpStart.Location = new System.Drawing.Point(105, 10);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(180, 26);
            this.dtpStart.TabIndex = 0;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEnd.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpEnd.Location = new System.Drawing.Point(105, 56);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(180, 26);
            this.dtpEnd.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSearch.Location = new System.Drawing.Point(723, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 90);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜    尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // columnID
            // 
            this.columnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnID.DataPropertyName = "Key";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnID.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnID.HeaderText = "人員編號";
            this.columnID.MaxInputLength = 128;
            this.columnID.MinimumWidth = 130;
            this.columnID.Name = "columnID";
            this.columnID.ReadOnly = true;
            // 
            // columnName
            // 
            this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnName.DataPropertyName = "ChineseName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnName.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnName.HeaderText = "姓名";
            this.columnName.MaxInputLength = 128;
            this.columnName.MinimumWidth = 80;
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnPhone
            // 
            this.columnPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPhone.DataPropertyName = "Phone";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnPhone.DefaultCellStyle = dataGridViewCellStyle4;
            this.columnPhone.HeaderText = "電話";
            this.columnPhone.MaxInputLength = 128;
            this.columnPhone.MinimumWidth = 80;
            this.columnPhone.Name = "columnPhone";
            this.columnPhone.ReadOnly = true;
            // 
            // columnCardNo
            // 
            this.columnCardNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCardNo.DataPropertyName = "CardNumber";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnCardNo.DefaultCellStyle = dataGridViewCellStyle5;
            this.columnCardNo.HeaderText = "卡號";
            this.columnCardNo.MaxInputLength = 4;
            this.columnCardNo.MinimumWidth = 70;
            this.columnCardNo.Name = "columnCardNo";
            this.columnCardNo.ReadOnly = true;
            // 
            // columnDate
            // 
            this.columnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDate.DataPropertyName = "Date";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.columnDate.HeaderText = "刷卡日期";
            this.columnDate.MaxInputLength = 128;
            this.columnDate.MinimumWidth = 110;
            this.columnDate.Name = "columnDate";
            this.columnDate.ReadOnly = true;
            // 
            // columnCount
            // 
            this.columnCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCount.DataPropertyName = "Count";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnCount.DefaultCellStyle = dataGridViewCellStyle7;
            this.columnCount.HeaderText = "刷卡次數";
            this.columnCount.MaxInputLength = 10;
            this.columnCount.MinimumWidth = 80;
            this.columnCount.Name = "columnCount";
            this.columnCount.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 616);
            this.Controls.Add(this.tlpBase);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.MinimumSize = new System.Drawing.Size(850, 650);
            this.Name = "FormMain";
            this.Text = "刷卡資料整合系統 V1.0.0.1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.tlpSearchDateBase.ResumeLayout(false);
            this.tlpSearchDateBase.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbDisplay.ResumeLayout(false);
            this.gbDisplay.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tlpDateSearch.ResumeLayout(false);
            this.tlpDateSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearData;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.TableLayoutPanel tlpSearchDateBase;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tlpDateSearch;
        private System.Windows.Forms.LinkLabel llbSearchEnd;
        private System.Windows.Forms.Label lblDotSearchStart;
        private System.Windows.Forms.Label lblDotSearchEnd;
        private System.Windows.Forms.LinkLabel llbSearchStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.GroupBox gbDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rdDisplayCount;
        private System.Windows.Forms.RadioButton rdDisplayAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbCardNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCount;
    }
}

