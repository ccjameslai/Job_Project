namespace DemoGUI
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
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_IdCount = new System.Windows.Forms.TextBox();
            this.label_datacount = new System.Windows.Forms.Label();
            this.button_Import = new System.Windows.Forms.Button();
            this.button_Export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimePicker.Location = new System.Drawing.Point(92, 27);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(143, 22);
            this.StartTimePicker.TabIndex = 1;
            this.StartTimePicker.Value = new System.DateTime(2016, 12, 21, 12, 12, 26, 0);
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimePicker.Location = new System.Drawing.Point(90, 63);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.Size = new System.Drawing.Size(143, 22);
            this.EndTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Time";
            // 
            // textBox_IdCount
            // 
            this.textBox_IdCount.Location = new System.Drawing.Point(92, 173);
            this.textBox_IdCount.Name = "textBox_IdCount";
            this.textBox_IdCount.Size = new System.Drawing.Size(100, 22);
            this.textBox_IdCount.TabIndex = 6;
            // 
            // label_datacount
            // 
            this.label_datacount.AutoSize = true;
            this.label_datacount.Location = new System.Drawing.Point(23, 176);
            this.label_datacount.Name = "label_datacount";
            this.label_datacount.Size = new System.Drawing.Size(58, 12);
            this.label_datacount.TabIndex = 7;
            this.label_datacount.Text = "Piece count";
            // 
            // button_Import
            // 
            this.button_Import.Location = new System.Drawing.Point(143, 216);
            this.button_Import.Name = "button_Import";
            this.button_Import.Size = new System.Drawing.Size(78, 34);
            this.button_Import.TabIndex = 8;
            this.button_Import.Text = "Import";
            this.button_Import.UseVisualStyleBackColor = true;
            this.button_Import.Click += new System.EventHandler(this.button_Import_Click);
            // 
            // button_Export
            // 
            this.button_Export.Location = new System.Drawing.Point(35, 216);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(78, 34);
            this.button_Export.TabIndex = 9;
            this.button_Export.Text = "Export";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 262);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.button_Import);
            this.Controls.Add(this.label_datacount);
            this.Controls.Add(this.textBox_IdCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Name = "Form1";
            this.Text = "DB Exporter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_IdCount;
        private System.Windows.Forms.Label label_datacount;
        private System.Windows.Forms.Button button_Import;
        private System.Windows.Forms.Button button_Export;
    }
}

