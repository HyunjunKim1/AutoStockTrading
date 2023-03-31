
namespace AutoStockTrading
{
    partial class form_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.axKHOpenAPI = new AxKHOpenAPILib.AxKHOpenAPI();
            this.lbl_Log = new System.Windows.Forms.Label();
            this.pnl_Main = new Guna.UI2.WinForms.Guna2Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnl_Dock2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer11 = new System.Windows.Forms.SplitContainer();
            this.splitContainer14 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.gDgv_Condition = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cLbox_ConditionList = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_SelectedCondition = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox_Account = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox_Status = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.사용방법ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pnl_Dock1 = new System.Windows.Forms.Panel();
            this.pnl_StatusIcon = new System.Windows.Forms.Panel();
            this.iBtn_Login = new Guna.UI2.WinForms.Guna2ImageButton();
            this.iBtn_Log = new Guna.UI2.WinForms.Guna2ImageButton();
            this.iBtn_Status = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnl_Title = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnl_MarginRight = new System.Windows.Forms.Panel();
            this.pnl_MarginLeft = new System.Windows.Forms.Panel();
            this.pnl_MarginBottom = new System.Windows.Forms.Panel();
            this.pnl_MarginTop = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).BeginInit();
            this.pnl_Main.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnl_Dock2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).BeginInit();
            this.splitContainer11.Panel1.SuspendLayout();
            this.splitContainer11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer14)).BeginInit();
            this.splitContainer14.Panel1.SuspendLayout();
            this.splitContainer14.Panel2.SuspendLayout();
            this.splitContainer14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDgv_Condition)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnl_StatusIcon.SuspendLayout();
            this.pnl_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // axKHOpenAPI
            // 
            this.axKHOpenAPI.Enabled = true;
            this.axKHOpenAPI.Location = new System.Drawing.Point(917, 560);
            this.axKHOpenAPI.Name = "axKHOpenAPI";
            this.axKHOpenAPI.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI.OcxState")));
            this.axKHOpenAPI.Size = new System.Drawing.Size(100, 50);
            this.axKHOpenAPI.TabIndex = 0;
            this.axKHOpenAPI.OnEventConnect += new AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEventHandler(this.axKHOpenAPI_OnEventConnect);
            // 
            // lbl_Log
            // 
            this.lbl_Log.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbl_Log.Location = new System.Drawing.Point(0, 1075);
            this.lbl_Log.Name = "lbl_Log";
            this.lbl_Log.Size = new System.Drawing.Size(2060, 25);
            this.lbl_Log.TabIndex = 2;
            this.lbl_Log.Text = "[04:34:40:617] [System] Successfully loaded the program.";
            this.lbl_Log.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.pnl_Main.Controls.Add(this.tabControl2);
            this.pnl_Main.Controls.Add(this.pnl_Dock1);
            this.pnl_Main.Controls.Add(this.pnl_StatusIcon);
            this.pnl_Main.Controls.Add(this.pnl_Title);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(5, 5);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(2050, 1065);
            this.pnl_Main.TabIndex = 3;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(275, 27);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1775, 1038);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.pnl_Dock2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1767, 1012);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "1) 자동매매";
            // 
            // pnl_Dock2
            // 
            this.pnl_Dock2.AutoScroll = true;
            this.pnl_Dock2.AutoScrollMargin = new System.Drawing.Size(0, 1);
            this.pnl_Dock2.AutoScrollMinSize = new System.Drawing.Size(0, 1);
            this.pnl_Dock2.Controls.Add(this.panel1);
            this.pnl_Dock2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Dock2.Location = new System.Drawing.Point(3, 3);
            this.pnl_Dock2.Name = "pnl_Dock2";
            this.pnl_Dock2.Size = new System.Drawing.Size(1761, 1006);
            this.pnl_Dock2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1761, 1006);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1761, 979);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1753, 953);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1) 매매조건";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer11);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer3.Size = new System.Drawing.Size(1747, 947);
            this.splitContainer3.SplitterDistance = 856;
            this.splitContainer3.TabIndex = 16;
            // 
            // splitContainer11
            // 
            this.splitContainer11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer11.Location = new System.Drawing.Point(0, 0);
            this.splitContainer11.Name = "splitContainer11";
            this.splitContainer11.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer11.Panel1
            // 
            this.splitContainer11.Panel1.Controls.Add(this.splitContainer14);
            this.splitContainer11.Size = new System.Drawing.Size(856, 947);
            this.splitContainer11.SplitterDistance = 473;
            this.splitContainer11.TabIndex = 17;
            // 
            // splitContainer14
            // 
            this.splitContainer14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer14.Location = new System.Drawing.Point(0, 0);
            this.splitContainer14.Name = "splitContainer14";
            this.splitContainer14.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer14.Panel1
            // 
            this.splitContainer14.Panel1.Controls.Add(this.label8);
            // 
            // splitContainer14.Panel2
            // 
            this.splitContainer14.Panel2.Controls.Add(this.gDgv_Condition);
            this.splitContainer14.Size = new System.Drawing.Size(856, 473);
            this.splitContainer14.SplitterDistance = 43;
            this.splitContainer14.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Condition Setting";
            // 
            // gDgv_Condition
            // 
            this.gDgv_Condition.AllowUserToAddRows = false;
            this.gDgv_Condition.AllowUserToDeleteRows = false;
            this.gDgv_Condition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gDgv_Condition.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDgv_Condition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gDgv_Condition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gDgv_Condition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDgv_Condition.DefaultCellStyle = dataGridViewCellStyle2;
            this.gDgv_Condition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDgv_Condition.Location = new System.Drawing.Point(0, 0);
            this.gDgv_Condition.Name = "gDgv_Condition";
            this.gDgv_Condition.RowHeadersVisible = false;
            this.gDgv_Condition.RowTemplate.Height = 23;
            this.gDgv_Condition.Size = new System.Drawing.Size(852, 422);
            this.gDgv_Condition.TabIndex = 9;
            this.gDgv_Condition.TabStop = false;
            this.gDgv_Condition.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gDgv_Condition_CellContentClick);
            this.gDgv_Condition.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gDgv_Condition_DataError);
            // 
            // Column11
            // 
            this.Column11.HeaderText = "조건";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "설정";
            this.Column12.Name = "Column12";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cLbox_ConditionList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 943);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "키움 조건 검색식 (모바일 X)";
            // 
            // cLbox_ConditionList
            // 
            this.cLbox_ConditionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLbox_ConditionList.FormattingEnabled = true;
            this.cLbox_ConditionList.Location = new System.Drawing.Point(3, 17);
            this.cLbox_ConditionList.Name = "cLbox_ConditionList";
            this.cLbox_ConditionList.Size = new System.Drawing.Size(877, 923);
            this.cLbox_ConditionList.TabIndex = 2;
            this.cLbox_ConditionList.SelectedIndexChanged += new System.EventHandler(this.cLbox_ConditionList_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Start);
            this.tabPage2.Controls.Add(this.btn_Stop);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1753, 953);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2) 검색시작";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            this.btn_Start.Enabled = false;
            this.btn_Start.Location = new System.Drawing.Point(817, 433);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(118, 40);
            this.btn_Start.TabIndex = 14;
            this.btn_Start.Text = "시  작";
            this.btn_Start.UseVisualStyleBackColor = true;
            // 
            // btn_Stop
            // 
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Location = new System.Drawing.Point(817, 479);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(118, 40);
            this.btn_Stop.TabIndex = 15;
            this.btn_Stop.Text = "정  지";
            this.btn_Stop.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1753, 953);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "3) 조건검색식 & 로그";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1753, 953);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "4) 평가금 분석";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3,
            this.toolStripTextBox_SelectedCondition,
            this.toolStripTextBox2,
            this.toolStripComboBox_Account,
            this.toolStripTextBox_Status,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1761, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.ReadOnly = true;
            this.toolStripTextBox3.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox3.Text = "조건식:";
            // 
            // toolStripTextBox_SelectedCondition
            // 
            this.toolStripTextBox_SelectedCondition.BackColor = System.Drawing.Color.DarkGray;
            this.toolStripTextBox_SelectedCondition.Name = "toolStripTextBox_SelectedCondition";
            this.toolStripTextBox_SelectedCondition.ReadOnly = true;
            this.toolStripTextBox_SelectedCondition.Size = new System.Drawing.Size(320, 23);
            this.toolStripTextBox_SelectedCondition.Text = "선택된 조건식이 없습니다. 조건식을 체크해주세요.";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(60, 23);
            this.toolStripTextBox2.Text = "계좌번호:";
            // 
            // toolStripComboBox_Account
            // 
            this.toolStripComboBox_Account.Name = "toolStripComboBox_Account";
            this.toolStripComboBox_Account.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripTextBox_Status
            // 
            this.toolStripTextBox_Status.Name = "toolStripTextBox_Status";
            this.toolStripTextBox_Status.Size = new System.Drawing.Size(150, 23);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사용방법ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 23);
            this.toolStripMenuItem1.Text = "도움말";
            // 
            // 사용방법ToolStripMenuItem
            // 
            this.사용방법ToolStripMenuItem.Name = "사용방법ToolStripMenuItem";
            this.사용방법ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.사용방법ToolStripMenuItem.Text = "사용방법";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1767, 1012);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "2) 상승종목 캐쳐";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pnl_Dock1
            // 
            this.pnl_Dock1.AutoScroll = true;
            this.pnl_Dock1.AutoScrollMargin = new System.Drawing.Size(0, 1);
            this.pnl_Dock1.AutoScrollMinSize = new System.Drawing.Size(0, 1);
            this.pnl_Dock1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Dock1.Location = new System.Drawing.Point(32, 27);
            this.pnl_Dock1.Name = "pnl_Dock1";
            this.pnl_Dock1.Size = new System.Drawing.Size(243, 1038);
            this.pnl_Dock1.TabIndex = 4;
            // 
            // pnl_StatusIcon
            // 
            this.pnl_StatusIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnl_StatusIcon.Controls.Add(this.iBtn_Login);
            this.pnl_StatusIcon.Controls.Add(this.iBtn_Log);
            this.pnl_StatusIcon.Controls.Add(this.iBtn_Status);
            this.pnl_StatusIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_StatusIcon.Location = new System.Drawing.Point(0, 27);
            this.pnl_StatusIcon.Name = "pnl_StatusIcon";
            this.pnl_StatusIcon.Size = new System.Drawing.Size(32, 1038);
            this.pnl_StatusIcon.TabIndex = 3;
            // 
            // iBtn_Login
            // 
            this.iBtn_Login.BackColor = System.Drawing.Color.Transparent;
            this.iBtn_Login.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.iBtn_Login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iBtn_Login.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.iBtn_Login.Image = global::AutoStockTrading.Properties.Resources.LOGIN_OFF;
            this.iBtn_Login.ImageOffset = new System.Drawing.Point(0, 0);
            this.iBtn_Login.ImageRotate = 0F;
            this.iBtn_Login.ImageSize = new System.Drawing.Size(30, 30);
            this.iBtn_Login.Location = new System.Drawing.Point(0, 1001);
            this.iBtn_Login.Name = "iBtn_Login";
            this.iBtn_Login.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.iBtn_Login.Size = new System.Drawing.Size(32, 37);
            this.iBtn_Login.TabIndex = 5;
            this.iBtn_Login.Tag = "LOG";
            // 
            // iBtn_Log
            // 
            this.iBtn_Log.BackColor = System.Drawing.Color.Transparent;
            this.iBtn_Log.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.iBtn_Log.Dock = System.Windows.Forms.DockStyle.Top;
            this.iBtn_Log.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.iBtn_Log.Image = global::AutoStockTrading.Properties.Resources.LOG_OFF;
            this.iBtn_Log.ImageOffset = new System.Drawing.Point(0, 0);
            this.iBtn_Log.ImageRotate = 0F;
            this.iBtn_Log.ImageSize = new System.Drawing.Size(30, 30);
            this.iBtn_Log.Location = new System.Drawing.Point(0, 37);
            this.iBtn_Log.Name = "iBtn_Log";
            this.iBtn_Log.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.iBtn_Log.Size = new System.Drawing.Size(32, 37);
            this.iBtn_Log.TabIndex = 4;
            this.iBtn_Log.Tag = "LOG";
            this.iBtn_Log.Click += new System.EventHandler(this.iBtn_Dockable_Click);
            // 
            // iBtn_Status
            // 
            this.iBtn_Status.BackColor = System.Drawing.Color.Transparent;
            this.iBtn_Status.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.iBtn_Status.Dock = System.Windows.Forms.DockStyle.Top;
            this.iBtn_Status.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.iBtn_Status.Image = global::AutoStockTrading.Properties.Resources.STATUS_OFF;
            this.iBtn_Status.ImageOffset = new System.Drawing.Point(0, 0);
            this.iBtn_Status.ImageRotate = 0F;
            this.iBtn_Status.ImageSize = new System.Drawing.Size(30, 30);
            this.iBtn_Status.Location = new System.Drawing.Point(0, 0);
            this.iBtn_Status.Name = "iBtn_Status";
            this.iBtn_Status.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.iBtn_Status.Size = new System.Drawing.Size(32, 37);
            this.iBtn_Status.TabIndex = 3;
            this.iBtn_Status.Tag = "STATUS";
            this.iBtn_Status.Click += new System.EventHandler(this.iBtn_Dockable_Click);
            // 
            // pnl_Title
            // 
            this.pnl_Title.Controls.Add(this.label1);
            this.pnl_Title.Controls.Add(this.lbl_Version);
            this.pnl_Title.Controls.Add(this.guna2ControlBox3);
            this.pnl_Title.Controls.Add(this.guna2ControlBox2);
            this.pnl_Title.Controls.Add(this.Btn_Close);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.pnl_Title.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnl_Title.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnl_Title.Location = new System.Drawing.Point(0, 0);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(2050, 27);
            this.pnl_Title.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Auto Stock Trading";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Version
            // 
            this.lbl_Version.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Version.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Version.Location = new System.Drawing.Point(1874, 0);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(86, 27);
            this.lbl_Version.TabIndex = 4;
            this.lbl_Version.Text = "Ver 1.2.3";
            this.lbl_Version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1960, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(30, 27);
            this.guna2ControlBox3.TabIndex = 3;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1990, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(30, 27);
            this.guna2ControlBox2.TabIndex = 2;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Close.CustomClick = true;
            this.Btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Close.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Close.IconColor = System.Drawing.Color.Black;
            this.Btn_Close.Location = new System.Drawing.Point(2020, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 27);
            this.Btn_Close.TabIndex = 1;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // pnl_MarginRight
            // 
            this.pnl_MarginRight.BackColor = System.Drawing.Color.Transparent;
            this.pnl_MarginRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_MarginRight.Enabled = false;
            this.pnl_MarginRight.Location = new System.Drawing.Point(2055, 0);
            this.pnl_MarginRight.Name = "pnl_MarginRight";
            this.pnl_MarginRight.Size = new System.Drawing.Size(5, 1075);
            this.pnl_MarginRight.TabIndex = 6;
            // 
            // pnl_MarginLeft
            // 
            this.pnl_MarginLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnl_MarginLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_MarginLeft.Enabled = false;
            this.pnl_MarginLeft.Location = new System.Drawing.Point(0, 0);
            this.pnl_MarginLeft.Name = "pnl_MarginLeft";
            this.pnl_MarginLeft.Size = new System.Drawing.Size(5, 1075);
            this.pnl_MarginLeft.TabIndex = 7;
            // 
            // pnl_MarginBottom
            // 
            this.pnl_MarginBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnl_MarginBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_MarginBottom.Enabled = false;
            this.pnl_MarginBottom.Location = new System.Drawing.Point(5, 1070);
            this.pnl_MarginBottom.Name = "pnl_MarginBottom";
            this.pnl_MarginBottom.Size = new System.Drawing.Size(2050, 5);
            this.pnl_MarginBottom.TabIndex = 8;
            // 
            // pnl_MarginTop
            // 
            this.pnl_MarginTop.BackColor = System.Drawing.Color.Transparent;
            this.pnl_MarginTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MarginTop.Enabled = false;
            this.pnl_MarginTop.Location = new System.Drawing.Point(5, 0);
            this.pnl_MarginTop.Name = "pnl_MarginTop";
            this.pnl_MarginTop.Size = new System.Drawing.Size(2050, 5);
            this.pnl_MarginTop.TabIndex = 9;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.pnl_Title;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2060, 1100);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_MarginTop);
            this.Controls.Add(this.pnl_MarginBottom);
            this.Controls.Add(this.pnl_MarginLeft);
            this.Controls.Add(this.pnl_MarginRight);
            this.Controls.Add(this.lbl_Log);
            this.Controls.Add(this.axKHOpenAPI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_Main_FormClosing);
            this.Load += new System.EventHandler(this.form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).EndInit();
            this.pnl_Main.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnl_Dock2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer11.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).EndInit();
            this.splitContainer11.ResumeLayout(false);
            this.splitContainer14.Panel1.ResumeLayout(false);
            this.splitContainer14.Panel1.PerformLayout();
            this.splitContainer14.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer14)).EndInit();
            this.splitContainer14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gDgv_Condition)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_StatusIcon.ResumeLayout(false);
            this.pnl_Title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI;
        public System.Windows.Forms.Label lbl_Log;
        private Guna.UI2.WinForms.Guna2Panel pnl_Main;
        private Guna.UI2.WinForms.Guna2GradientPanel pnl_Title;
        private System.Windows.Forms.Label lbl_Version;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox Btn_Close;
        private System.Windows.Forms.Panel pnl_MarginRight;
        private System.Windows.Forms.Panel pnl_MarginLeft;
        private System.Windows.Forms.Panel pnl_MarginBottom;
        private System.Windows.Forms.Panel pnl_MarginTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Dock2;
        private System.Windows.Forms.Panel pnl_Dock1;
        private System.Windows.Forms.Panel pnl_StatusIcon;
        private Guna.UI2.WinForms.Guna2ImageButton iBtn_Status;
        private Guna.UI2.WinForms.Guna2ImageButton iBtn_Log;
        private Guna.UI2.WinForms.Guna2ImageButton iBtn_Login;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_SelectedCondition;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_Account;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Status;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 사용방법ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer11;
        private System.Windows.Forms.SplitContainer splitContainer14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gDgv_Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox cLbox_ConditionList;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
    }
}

