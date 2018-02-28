namespace GetDataFromWeb
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
            this.ip_address = new System.Windows.Forms.TextBox();
            this.load_cell = new System.Windows.Forms.TextBox();
            this.btn_GrabDataStream = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bw_scale = new System.ComponentModel.BackgroundWorker();
            this.btn_StopDataStream = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ip_address
            // 
            this.ip_address.Location = new System.Drawing.Point(126, 26);
            this.ip_address.Name = "ip_address";
            this.ip_address.Size = new System.Drawing.Size(176, 25);
            this.ip_address.TabIndex = 0;
            this.ip_address.Text = "192.168.1.97";
            // 
            // load_cell
            // 
            this.load_cell.Location = new System.Drawing.Point(126, 71);
            this.load_cell.Multiline = true;
            this.load_cell.Name = "load_cell";
            this.load_cell.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.load_cell.Size = new System.Drawing.Size(176, 166);
            this.load_cell.TabIndex = 1;
            // 
            // btn_GrabDataStream
            // 
            this.btn_GrabDataStream.Location = new System.Drawing.Point(65, 261);
            this.btn_GrabDataStream.Name = "btn_GrabDataStream";
            this.btn_GrabDataStream.Size = new System.Drawing.Size(101, 36);
            this.btn_GrabDataStream.TabIndex = 2;
            this.btn_GrabDataStream.Text = "Grab";
            this.btn_GrabDataStream.UseVisualStyleBackColor = true;
            this.btn_GrabDataStream.Click += new System.EventHandler(this.btn_GrabDataStream_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "load cell reader:";
            // 
            // bw_scale
            // 
            this.bw_scale.WorkerReportsProgress = true;
            this.bw_scale.WorkerSupportsCancellation = true;
            this.bw_scale.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_scale_DoWork);
            this.bw_scale.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_scale_ProgressChanged);
            this.bw_scale.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_scale_RunWorkerCompleted);
            // 
            // btn_StopDataStream
            // 
            this.btn_StopDataStream.Location = new System.Drawing.Point(191, 261);
            this.btn_StopDataStream.Name = "btn_StopDataStream";
            this.btn_StopDataStream.Size = new System.Drawing.Size(101, 36);
            this.btn_StopDataStream.TabIndex = 5;
            this.btn_StopDataStream.Text = "Stop";
            this.btn_StopDataStream.UseVisualStyleBackColor = true;
            this.btn_StopDataStream.Click += new System.EventHandler(this.btn_StopDataStream_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 309);
            this.Controls.Add(this.btn_StopDataStream);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GrabDataStream);
            this.Controls.Add(this.load_cell);
            this.Controls.Add(this.ip_address);
            this.Name = "Form1";
            this.Text = "Web Grabber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip_address;
        private System.Windows.Forms.TextBox load_cell;
        private System.Windows.Forms.Button btn_GrabDataStream;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker bw_scale;
        private System.Windows.Forms.Button btn_StopDataStream;
    }
}

