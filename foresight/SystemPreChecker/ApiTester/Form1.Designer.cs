namespace ApiTester
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_APPChecker = new System.Windows.Forms.Button();
            this.backgroundWorker_7z = new System.ComponentModel.BackgroundWorker();
            this.pictureBox_7z = new System.Windows.Forms.PictureBox();
            this.label_7z = new System.Windows.Forms.Label();
            this.backgroundWorker_IIS = new System.ComponentModel.BackgroundWorker();
            this.label_IIS = new System.Windows.Forms.Label();
            this.pictureBox_IIS = new System.Windows.Forms.PictureBox();
            this.label_foresightlib = new System.Windows.Forms.Label();
            this.pictureBox_fstlib = new System.Windows.Forms.PictureBox();
            this.pictureBox_MCR = new System.Windows.Forms.PictureBox();
            this.label_MCR = new System.Windows.Forms.Label();
            this.label_SQL = new System.Windows.Forms.Label();
            this.pictureBox_SQL = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_MySQL = new System.Windows.Forms.PictureBox();
            this.label_Oracle = new System.Windows.Forms.Label();
            this.pictureBox_Oracle = new System.Windows.Forms.PictureBox();
            this.backgroundWorker_fstLib = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_MCR = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_SQL = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_MySQL = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_Oracle = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_SQLite = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_SQLite = new System.Windows.Forms.PictureBox();
            this.button_SQLServVersion = new System.Windows.Forms.Button();
            this.button_OracleVersion = new System.Windows.Forms.Button();
            this.button_Install = new System.Windows.Forms.Button();
            this.button_Install_fstlib = new System.Windows.Forms.Button();
            this.button_InstallMCR = new System.Windows.Forms.Button();
            this.button_InstallMySQL = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_SQLiteLocation = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_CPFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_PortCheck = new System.Windows.Forms.DataGridView();
            this.Process_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Current_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button_PortStatus = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_QueryPCStatus = new System.Windows.Forms.Button();
            this.dataGridView_QueryPCOperationTime = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Communication = new System.Windows.Forms.TabPage();
            this.button_Ping = new System.Windows.Forms.Button();
            this.textBox_COMU_PWD = new System.Windows.Forms.TextBox();
            this.label_PWD = new System.Windows.Forms.Label();
            this.textBox_COMU_UID = new System.Windows.Forms.TextBox();
            this.label_UID = new System.Windows.Forms.Label();
            this.label_DSN = new System.Windows.Forms.Label();
            this.comboBox_DSN = new System.Windows.Forms.ComboBox();
            this.label_IP = new System.Windows.Forms.Label();
            this.textBox_Communication = new System.Windows.Forms.TextBox();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.button_Communication = new System.Windows.Forms.Button();
            this.backgroundWorker_Ping = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_DBConnection = new System.ComponentModel.BackgroundWorker();
            this.loadingCircle_Ping = new MRG.Controls.UI.LoadingCircle();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_7z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fstlib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MCR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MySQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Oracle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SQLite)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PortCheck)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QueryPCOperationTime)).BeginInit();
            this.Communication.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_APPChecker
            // 
            this.button_APPChecker.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_APPChecker.Location = new System.Drawing.Point(125, 343);
            this.button_APPChecker.Name = "button_APPChecker";
            this.button_APPChecker.Size = new System.Drawing.Size(139, 41);
            this.button_APPChecker.TabIndex = 0;
            this.button_APPChecker.Text = "Check";
            this.button_APPChecker.UseVisualStyleBackColor = true;
            this.button_APPChecker.Click += new System.EventHandler(this.button_APPChecker_Click);
            // 
            // backgroundWorker_7z
            // 
            this.backgroundWorker_7z.WorkerReportsProgress = true;
            this.backgroundWorker_7z.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_7z_DoWork);
            this.backgroundWorker_7z.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_7z_RunWorkerCompleted);
            // 
            // pictureBox_7z
            // 
            this.pictureBox_7z.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_7z.InitialImage")));
            this.pictureBox_7z.Location = new System.Drawing.Point(181, 32);
            this.pictureBox_7z.Name = "pictureBox_7z";
            this.pictureBox_7z.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_7z.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_7z.TabIndex = 1;
            this.pictureBox_7z.TabStop = false;
            // 
            // label_7z
            // 
            this.label_7z.AutoSize = true;
            this.label_7z.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_7z.Location = new System.Drawing.Point(148, 32);
            this.label_7z.Name = "label_7z";
            this.label_7z.Size = new System.Drawing.Size(27, 19);
            this.label_7z.TabIndex = 2;
            this.label_7z.Text = "7z";
            // 
            // backgroundWorker_IIS
            // 
            this.backgroundWorker_IIS.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_IIS_DoWork);
            this.backgroundWorker_IIS.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_IIS_RunWorkerCompleted);
            // 
            // label_IIS
            // 
            this.label_IIS.AutoSize = true;
            this.label_IIS.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IIS.Location = new System.Drawing.Point(139, 63);
            this.label_IIS.Name = "label_IIS";
            this.label_IIS.Size = new System.Drawing.Size(36, 19);
            this.label_IIS.TabIndex = 3;
            this.label_IIS.Text = "IIS";
            // 
            // pictureBox_IIS
            // 
            this.pictureBox_IIS.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_IIS.InitialImage")));
            this.pictureBox_IIS.Location = new System.Drawing.Point(181, 63);
            this.pictureBox_IIS.Name = "pictureBox_IIS";
            this.pictureBox_IIS.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_IIS.TabIndex = 4;
            this.pictureBox_IIS.TabStop = false;
            // 
            // label_foresightlib
            // 
            this.label_foresightlib.AutoSize = true;
            this.label_foresightlib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_foresightlib.Location = new System.Drawing.Point(31, 94);
            this.label_foresightlib.Name = "label_foresightlib";
            this.label_foresightlib.Size = new System.Drawing.Size(144, 19);
            this.label_foresightlib.TabIndex = 11;
            this.label_foresightlib.Text = "foresightlibary";
            // 
            // pictureBox_fstlib
            // 
            this.pictureBox_fstlib.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_fstlib.InitialImage")));
            this.pictureBox_fstlib.Location = new System.Drawing.Point(181, 94);
            this.pictureBox_fstlib.Name = "pictureBox_fstlib";
            this.pictureBox_fstlib.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_fstlib.TabIndex = 12;
            this.pictureBox_fstlib.TabStop = false;
            // 
            // pictureBox_MCR
            // 
            this.pictureBox_MCR.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_MCR.InitialImage")));
            this.pictureBox_MCR.Location = new System.Drawing.Point(181, 125);
            this.pictureBox_MCR.Name = "pictureBox_MCR";
            this.pictureBox_MCR.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_MCR.TabIndex = 13;
            this.pictureBox_MCR.TabStop = false;
            // 
            // label_MCR
            // 
            this.label_MCR.AutoSize = true;
            this.label_MCR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MCR.Location = new System.Drawing.Point(139, 125);
            this.label_MCR.Name = "label_MCR";
            this.label_MCR.Size = new System.Drawing.Size(36, 19);
            this.label_MCR.TabIndex = 14;
            this.label_MCR.Text = "MCR";
            // 
            // label_SQL
            // 
            this.label_SQL.AutoSize = true;
            this.label_SQL.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SQL.Location = new System.Drawing.Point(76, 160);
            this.label_SQL.Name = "label_SQL";
            this.label_SQL.Size = new System.Drawing.Size(99, 19);
            this.label_SQL.TabIndex = 15;
            this.label_SQL.Text = "SQL Native";
            // 
            // pictureBox_SQL
            // 
            this.pictureBox_SQL.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_SQL.InitialImage")));
            this.pictureBox_SQL.Location = new System.Drawing.Point(181, 160);
            this.pictureBox_SQL.Name = "pictureBox_SQL";
            this.pictureBox_SQL.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_SQL.TabIndex = 16;
            this.pictureBox_SQL.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "MySQL";
            // 
            // pictureBox_MySQL
            // 
            this.pictureBox_MySQL.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_MySQL.InitialImage")));
            this.pictureBox_MySQL.Location = new System.Drawing.Point(181, 194);
            this.pictureBox_MySQL.Name = "pictureBox_MySQL";
            this.pictureBox_MySQL.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_MySQL.TabIndex = 18;
            this.pictureBox_MySQL.TabStop = false;
            // 
            // label_Oracle
            // 
            this.label_Oracle.AutoSize = true;
            this.label_Oracle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Oracle.Location = new System.Drawing.Point(112, 231);
            this.label_Oracle.Name = "label_Oracle";
            this.label_Oracle.Size = new System.Drawing.Size(63, 19);
            this.label_Oracle.TabIndex = 19;
            this.label_Oracle.Text = "Oracle";
            // 
            // pictureBox_Oracle
            // 
            this.pictureBox_Oracle.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Oracle.InitialImage")));
            this.pictureBox_Oracle.Location = new System.Drawing.Point(181, 231);
            this.pictureBox_Oracle.Name = "pictureBox_Oracle";
            this.pictureBox_Oracle.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_Oracle.TabIndex = 20;
            this.pictureBox_Oracle.TabStop = false;
            // 
            // backgroundWorker_fstLib
            // 
            this.backgroundWorker_fstLib.WorkerReportsProgress = true;
            this.backgroundWorker_fstLib.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_fstLib_DoWork);
            this.backgroundWorker_fstLib.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_fstLib_RunWorkerCompleted);
            // 
            // backgroundWorker_MCR
            // 
            this.backgroundWorker_MCR.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_MCR_DoWork);
            this.backgroundWorker_MCR.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_MCR_RunWorkerCompleted);
            // 
            // backgroundWorker_SQL
            // 
            this.backgroundWorker_SQL.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_SQL_DoWork);
            this.backgroundWorker_SQL.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_SQL_RunWorkerCompleted);
            // 
            // backgroundWorker_MySQL
            // 
            this.backgroundWorker_MySQL.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_MySQL_DoWork);
            this.backgroundWorker_MySQL.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_MySQL_RunWorkerCompleted);
            // 
            // backgroundWorker_Oracle
            // 
            this.backgroundWorker_Oracle.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Oracle_DoWork);
            this.backgroundWorker_Oracle.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_Oracle_RunWorkerCompleted);
            // 
            // backgroundWorker_SQLite
            // 
            this.backgroundWorker_SQLite.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_SQLite_DoWork);
            this.backgroundWorker_SQLite.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_SQLite_RunWorkerCompleted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "SQLite";
            // 
            // pictureBox_SQLite
            // 
            this.pictureBox_SQLite.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_SQLite.InitialImage")));
            this.pictureBox_SQLite.Location = new System.Drawing.Point(181, 265);
            this.pictureBox_SQLite.Name = "pictureBox_SQLite";
            this.pictureBox_SQLite.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_SQLite.TabIndex = 22;
            this.pictureBox_SQLite.TabStop = false;
            // 
            // button_SQLServVersion
            // 
            this.button_SQLServVersion.Location = new System.Drawing.Point(222, 160);
            this.button_SQLServVersion.Name = "button_SQLServVersion";
            this.button_SQLServVersion.Size = new System.Drawing.Size(45, 23);
            this.button_SQLServVersion.TabIndex = 23;
            this.button_SQLServVersion.Text = "show";
            this.button_SQLServVersion.UseVisualStyleBackColor = true;
            this.button_SQLServVersion.Visible = false;
            this.button_SQLServVersion.Click += new System.EventHandler(this.button_SQLServVersion_Click);
            // 
            // button_OracleVersion
            // 
            this.button_OracleVersion.Location = new System.Drawing.Point(222, 231);
            this.button_OracleVersion.Name = "button_OracleVersion";
            this.button_OracleVersion.Size = new System.Drawing.Size(45, 23);
            this.button_OracleVersion.TabIndex = 24;
            this.button_OracleVersion.Text = "show";
            this.button_OracleVersion.UseVisualStyleBackColor = true;
            this.button_OracleVersion.Visible = false;
            this.button_OracleVersion.Click += new System.EventHandler(this.button_OracleVersion_Click);
            // 
            // button_Install
            // 
            this.button_Install.Location = new System.Drawing.Point(288, 32);
            this.button_Install.Name = "button_Install";
            this.button_Install.Size = new System.Drawing.Size(53, 23);
            this.button_Install.TabIndex = 25;
            this.button_Install.Text = "Install";
            this.button_Install.UseVisualStyleBackColor = true;
            this.button_Install.Visible = false;
            this.button_Install.Click += new System.EventHandler(this.button_Install_Click);
            // 
            // button_Install_fstlib
            // 
            this.button_Install_fstlib.Location = new System.Drawing.Point(288, 95);
            this.button_Install_fstlib.Name = "button_Install_fstlib";
            this.button_Install_fstlib.Size = new System.Drawing.Size(53, 23);
            this.button_Install_fstlib.TabIndex = 26;
            this.button_Install_fstlib.Text = "Install";
            this.button_Install_fstlib.UseVisualStyleBackColor = true;
            this.button_Install_fstlib.Visible = false;
            this.button_Install_fstlib.Click += new System.EventHandler(this.button_Install_fstlib_Click);
            // 
            // button_InstallMCR
            // 
            this.button_InstallMCR.Location = new System.Drawing.Point(288, 126);
            this.button_InstallMCR.Name = "button_InstallMCR";
            this.button_InstallMCR.Size = new System.Drawing.Size(53, 23);
            this.button_InstallMCR.TabIndex = 27;
            this.button_InstallMCR.Text = "Install";
            this.button_InstallMCR.UseVisualStyleBackColor = true;
            this.button_InstallMCR.Visible = false;
            this.button_InstallMCR.Click += new System.EventHandler(this.button_InstallMCR_Click);
            // 
            // button_InstallMySQL
            // 
            this.button_InstallMySQL.Location = new System.Drawing.Point(288, 194);
            this.button_InstallMySQL.Name = "button_InstallMySQL";
            this.button_InstallMySQL.Size = new System.Drawing.Size(53, 23);
            this.button_InstallMySQL.TabIndex = 28;
            this.button_InstallMySQL.Text = "Install";
            this.button_InstallMySQL.UseVisualStyleBackColor = true;
            this.button_InstallMySQL.Visible = false;
            this.button_InstallMySQL.Click += new System.EventHandler(this.button_MySQL_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.Communication);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 489);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_SQLiteLocation);
            this.tabPage1.Controls.Add(this.pictureBox_fstlib);
            this.tabPage1.Controls.Add(this.button_InstallMySQL);
            this.tabPage1.Controls.Add(this.button_APPChecker);
            this.tabPage1.Controls.Add(this.button_InstallMCR);
            this.tabPage1.Controls.Add(this.pictureBox_7z);
            this.tabPage1.Controls.Add(this.button_Install_fstlib);
            this.tabPage1.Controls.Add(this.label_7z);
            this.tabPage1.Controls.Add(this.button_Install);
            this.tabPage1.Controls.Add(this.label_IIS);
            this.tabPage1.Controls.Add(this.button_OracleVersion);
            this.tabPage1.Controls.Add(this.pictureBox_IIS);
            this.tabPage1.Controls.Add(this.button_SQLServVersion);
            this.tabPage1.Controls.Add(this.label_foresightlib);
            this.tabPage1.Controls.Add(this.pictureBox_SQLite);
            this.tabPage1.Controls.Add(this.pictureBox_MCR);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label_MCR);
            this.tabPage1.Controls.Add(this.pictureBox_Oracle);
            this.tabPage1.Controls.Add(this.label_SQL);
            this.tabPage1.Controls.Add(this.label_Oracle);
            this.tabPage1.Controls.Add(this.pictureBox_SQL);
            this.tabPage1.Controls.Add(this.pictureBox_MySQL);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(418, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PreCheck";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_SQLiteLocation
            // 
            this.button_SQLiteLocation.Location = new System.Drawing.Point(222, 266);
            this.button_SQLiteLocation.Name = "button_SQLiteLocation";
            this.button_SQLiteLocation.Size = new System.Drawing.Size(45, 23);
            this.button_SQLiteLocation.TabIndex = 29;
            this.button_SQLiteLocation.Text = "show";
            this.button_SQLiteLocation.UseVisualStyleBackColor = true;
            this.button_SQLiteLocation.Visible = false;
            this.button_SQLiteLocation.Click += new System.EventHandler(this.button_SQLiteLocation_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox_CPFolder);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox_Port);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView_PortCheck);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button_PortStatus);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(418, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UpdatedCheck";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Control Panel Folder";
            // 
            // textBox_CPFolder
            // 
            this.textBox_CPFolder.Location = new System.Drawing.Point(53, 47);
            this.textBox_CPFolder.Name = "textBox_CPFolder";
            this.textBox_CPFolder.Size = new System.Drawing.Size(274, 22);
            this.textBox_CPFolder.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Port:";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(109, 145);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(111, 22);
            this.textBox_Port.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(247, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_PortCheck
            // 
            this.dataGridView_PortCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_PortCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PortCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Process_Name,
            this.Port,
            this.Current_Status});
            this.dataGridView_PortCheck.Location = new System.Drawing.Point(6, 199);
            this.dataGridView_PortCheck.Name = "dataGridView_PortCheck";
            this.dataGridView_PortCheck.RowTemplate.Height = 24;
            this.dataGridView_PortCheck.Size = new System.Drawing.Size(406, 258);
            this.dataGridView_PortCheck.TabIndex = 2;
            // 
            // Process_Name
            // 
            this.Process_Name.HeaderText = "Process Name";
            this.Process_Name.Name = "Process_Name";
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            // 
            // Current_Status
            // 
            this.Current_Status.HeaderText = "Current Status";
            this.Current_Status.Name = "Current_Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "System Port Status";
            // 
            // button_PortStatus
            // 
            this.button_PortStatus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PortStatus.Location = new System.Drawing.Point(247, 85);
            this.button_PortStatus.Name = "button_PortStatus";
            this.button_PortStatus.Size = new System.Drawing.Size(80, 30);
            this.button_PortStatus.TabIndex = 0;
            this.button_PortStatus.Text = "check\r\n";
            this.button_PortStatus.UseVisualStyleBackColor = true;
            this.button_PortStatus.Click += new System.EventHandler(this.button_PortStatus_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button_QueryPCStatus);
            this.tabPage3.Controls.Add(this.dataGridView_QueryPCOperationTime);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(418, 463);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PC operation time";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_QueryPCStatus
            // 
            this.button_QueryPCStatus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QueryPCStatus.Location = new System.Drawing.Point(149, 38);
            this.button_QueryPCStatus.Name = "button_QueryPCStatus";
            this.button_QueryPCStatus.Size = new System.Drawing.Size(92, 31);
            this.button_QueryPCStatus.TabIndex = 1;
            this.button_QueryPCStatus.Text = "Query";
            this.button_QueryPCStatus.UseVisualStyleBackColor = true;
            this.button_QueryPCStatus.Click += new System.EventHandler(this.button_QueryPCStatus_Click);
            // 
            // dataGridView_QueryPCOperationTime
            // 
            this.dataGridView_QueryPCOperationTime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_QueryPCOperationTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QueryPCOperationTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Status});
            this.dataGridView_QueryPCOperationTime.Location = new System.Drawing.Point(4, 98);
            this.dataGridView_QueryPCOperationTime.Name = "dataGridView_QueryPCOperationTime";
            this.dataGridView_QueryPCOperationTime.RowTemplate.Height = 24;
            this.dataGridView_QueryPCOperationTime.Size = new System.Drawing.Size(411, 362);
            this.dataGridView_QueryPCOperationTime.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Communication
            // 
            this.Communication.Controls.Add(this.loadingCircle_Ping);
            this.Communication.Controls.Add(this.button_Ping);
            this.Communication.Controls.Add(this.textBox_COMU_PWD);
            this.Communication.Controls.Add(this.label_PWD);
            this.Communication.Controls.Add(this.textBox_COMU_UID);
            this.Communication.Controls.Add(this.label_UID);
            this.Communication.Controls.Add(this.label_DSN);
            this.Communication.Controls.Add(this.comboBox_DSN);
            this.Communication.Controls.Add(this.label_IP);
            this.Communication.Controls.Add(this.textBox_Communication);
            this.Communication.Controls.Add(this.textBox_IP);
            this.Communication.Controls.Add(this.button_Communication);
            this.Communication.Location = new System.Drawing.Point(4, 22);
            this.Communication.Name = "Communication";
            this.Communication.Size = new System.Drawing.Size(418, 463);
            this.Communication.TabIndex = 3;
            this.Communication.Text = "Communication";
            this.Communication.UseVisualStyleBackColor = true;
            // 
            // button_Ping
            // 
            this.button_Ping.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ping.Location = new System.Drawing.Point(290, 31);
            this.button_Ping.Name = "button_Ping";
            this.button_Ping.Size = new System.Drawing.Size(81, 28);
            this.button_Ping.TabIndex = 11;
            this.button_Ping.Text = "Ping";
            this.button_Ping.UseVisualStyleBackColor = true;
            this.button_Ping.Click += new System.EventHandler(this.button_Ping_Click);
            // 
            // textBox_COMU_PWD
            // 
            this.textBox_COMU_PWD.Location = new System.Drawing.Point(144, 379);
            this.textBox_COMU_PWD.Name = "textBox_COMU_PWD";
            this.textBox_COMU_PWD.PasswordChar = '*';
            this.textBox_COMU_PWD.Size = new System.Drawing.Size(154, 22);
            this.textBox_COMU_PWD.TabIndex = 10;
            // 
            // label_PWD
            // 
            this.label_PWD.AutoSize = true;
            this.label_PWD.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PWD.Location = new System.Drawing.Point(79, 379);
            this.label_PWD.Name = "label_PWD";
            this.label_PWD.Size = new System.Drawing.Size(45, 19);
            this.label_PWD.TabIndex = 9;
            this.label_PWD.Text = "PWD:";
            // 
            // textBox_COMU_UID
            // 
            this.textBox_COMU_UID.Location = new System.Drawing.Point(144, 327);
            this.textBox_COMU_UID.Name = "textBox_COMU_UID";
            this.textBox_COMU_UID.Size = new System.Drawing.Size(154, 22);
            this.textBox_COMU_UID.TabIndex = 8;
            // 
            // label_UID
            // 
            this.label_UID.AutoSize = true;
            this.label_UID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UID.Location = new System.Drawing.Point(79, 331);
            this.label_UID.Name = "label_UID";
            this.label_UID.Size = new System.Drawing.Size(45, 19);
            this.label_UID.TabIndex = 7;
            this.label_UID.Text = "UID:";
            // 
            // label_DSN
            // 
            this.label_DSN.AutoSize = true;
            this.label_DSN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DSN.Location = new System.Drawing.Point(79, 280);
            this.label_DSN.Name = "label_DSN";
            this.label_DSN.Size = new System.Drawing.Size(45, 19);
            this.label_DSN.TabIndex = 6;
            this.label_DSN.Text = "DSN:";
            // 
            // comboBox_DSN
            // 
            this.comboBox_DSN.FormattingEnabled = true;
            this.comboBox_DSN.Location = new System.Drawing.Point(144, 282);
            this.comboBox_DSN.Name = "comboBox_DSN";
            this.comboBox_DSN.Size = new System.Drawing.Size(121, 20);
            this.comboBox_DSN.TabIndex = 5;
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IP.Location = new System.Drawing.Point(61, 36);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(45, 19);
            this.label_IP.TabIndex = 3;
            this.label_IP.Text = "IP: ";
            // 
            // textBox_Communication
            // 
            this.textBox_Communication.Location = new System.Drawing.Point(7, 87);
            this.textBox_Communication.Multiline = true;
            this.textBox_Communication.Name = "textBox_Communication";
            this.textBox_Communication.Size = new System.Drawing.Size(411, 165);
            this.textBox_Communication.TabIndex = 2;
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(112, 33);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(151, 22);
            this.textBox_IP.TabIndex = 1;
            // 
            // button_Communication
            // 
            this.button_Communication.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Communication.Location = new System.Drawing.Point(144, 419);
            this.button_Communication.Name = "button_Communication";
            this.button_Communication.Size = new System.Drawing.Size(81, 29);
            this.button_Communication.TabIndex = 0;
            this.button_Communication.Text = "Check";
            this.button_Communication.UseVisualStyleBackColor = true;
            this.button_Communication.Click += new System.EventHandler(this.button_Communication_Click);
            // 
            // backgroundWorker_Ping
            // 
            this.backgroundWorker_Ping.WorkerReportsProgress = true;
            this.backgroundWorker_Ping.WorkerSupportsCancellation = true;
            this.backgroundWorker_Ping.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Ping_DoWork);
            this.backgroundWorker_Ping.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_Ping_ProgressChanged);
            this.backgroundWorker_Ping.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_Ping_RunWorkerCompleted);
            // 
            // backgroundWorker_DBConnection
            // 
            this.backgroundWorker_DBConnection.WorkerReportsProgress = true;
            this.backgroundWorker_DBConnection.WorkerSupportsCancellation = true;
            this.backgroundWorker_DBConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DBConnt_DoWork);
            // 
            // loadingCircle_Ping
            // 
            this.loadingCircle_Ping.Active = false;
            this.loadingCircle_Ping.Color = System.Drawing.Color.Navy;
            this.loadingCircle_Ping.Enabled = false;
            this.loadingCircle_Ping.InnerCircleRadius = 8;
            this.loadingCircle_Ping.Location = new System.Drawing.Point(191, 144);
            this.loadingCircle_Ping.Name = "loadingCircle_Ping";
            this.loadingCircle_Ping.NumberSpoke = 10;
            this.loadingCircle_Ping.OuterCircleRadius = 20;
            this.loadingCircle_Ping.RotationSpeed = 100;
            this.loadingCircle_Ping.Size = new System.Drawing.Size(50, 53);
            this.loadingCircle_Ping.SpokeThickness = 4;
            this.loadingCircle_Ping.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX;
            this.loadingCircle_Ping.TabIndex = 12;
            this.loadingCircle_Ping.Text = "loadingCircle1";
            this.loadingCircle_Ping.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 516);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SystemChecker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_7z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fstlib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MCR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MySQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Oracle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SQLite)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PortCheck)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QueryPCOperationTime)).EndInit();
            this.Communication.ResumeLayout(false);
            this.Communication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_APPChecker;
        private System.ComponentModel.BackgroundWorker backgroundWorker_7z;
        private System.Windows.Forms.PictureBox pictureBox_7z;
        private System.Windows.Forms.Label label_7z;
        private System.ComponentModel.BackgroundWorker backgroundWorker_IIS;
        private System.Windows.Forms.Label label_IIS;
        private System.Windows.Forms.PictureBox pictureBox_IIS;
        private System.Windows.Forms.Label label_foresightlib;
        private System.Windows.Forms.PictureBox pictureBox_fstlib;
        private System.Windows.Forms.PictureBox pictureBox_MCR;
        private System.Windows.Forms.Label label_MCR;
        private System.Windows.Forms.Label label_SQL;
        private System.Windows.Forms.PictureBox pictureBox_SQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_MySQL;
        private System.Windows.Forms.Label label_Oracle;
        private System.Windows.Forms.PictureBox pictureBox_Oracle;
        private System.ComponentModel.BackgroundWorker backgroundWorker_fstLib;
        private System.ComponentModel.BackgroundWorker backgroundWorker_MCR;
        private System.ComponentModel.BackgroundWorker backgroundWorker_SQL;
        private System.ComponentModel.BackgroundWorker backgroundWorker_MySQL;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Oracle;
        private System.ComponentModel.BackgroundWorker backgroundWorker_SQLite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_SQLite;
        private System.Windows.Forms.Button button_SQLServVersion;
        private System.Windows.Forms.Button button_OracleVersion;
        private System.Windows.Forms.Button button_Install;
        private System.Windows.Forms.Button button_Install_fstlib;
        private System.Windows.Forms.Button button_InstallMCR;
        private System.Windows.Forms.Button button_InstallMySQL;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_PortStatus;
        private System.Windows.Forms.DataGridView dataGridView_PortCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_QueryPCStatus;
        private System.Windows.Forms.DataGridView dataGridView_QueryPCOperationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_CPFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current_Status;
        private System.Windows.Forms.TabPage Communication;
        private System.Windows.Forms.Button button_Communication;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_Communication;
        private System.Windows.Forms.Label label_IP;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Ping;
        private System.Windows.Forms.ComboBox comboBox_DSN;
        private System.Windows.Forms.TextBox textBox_COMU_PWD;
        private System.Windows.Forms.Label label_PWD;
        private System.Windows.Forms.TextBox textBox_COMU_UID;
        private System.Windows.Forms.Label label_UID;
        private System.Windows.Forms.Label label_DSN;
        private System.ComponentModel.BackgroundWorker backgroundWorker_DBConnection;
        private System.Windows.Forms.Button button_Ping;
        private System.Windows.Forms.Button button_SQLiteLocation;
        private MRG.Controls.UI.LoadingCircle loadingCircle_Ping;
    }
}

