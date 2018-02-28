namespace UserInterface
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
            this.button_Export = new System.Windows.Forms.Button();
            this.textBox_UID = new System.Windows.Forms.TextBox();
            this.textBox_DSN = new System.Windows.Forms.TextBox();
            this.textBox_DbType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Export
            // 
            this.button_Export.Location = new System.Drawing.Point(158, 197);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(135, 53);
            this.button_Export.TabIndex = 0;
            this.button_Export.Text = "Export";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // textBox_UID
            // 
            this.textBox_UID.Location = new System.Drawing.Point(206, 143);
            this.textBox_UID.Name = "textBox_UID";
            this.textBox_UID.Size = new System.Drawing.Size(185, 22);
            this.textBox_UID.TabIndex = 1;
            this.textBox_UID.Text = "FATEK_MS_STDB";
            // 
            // textBox_DSN
            // 
            this.textBox_DSN.Location = new System.Drawing.Point(206, 101);
            this.textBox_DSN.Name = "textBox_DSN";
            this.textBox_DSN.Size = new System.Drawing.Size(185, 22);
            this.textBox_DSN.TabIndex = 2;
            this.textBox_DSN.Text = "DB235";
            // 
            // textBox_DbType
            // 
            this.textBox_DbType.Location = new System.Drawing.Point(206, 55);
            this.textBox_DbType.Name = "textBox_DbType";
            this.textBox_DbType.Size = new System.Drawing.Size(185, 22);
            this.textBox_DbType.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "UID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "DSN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_DbType);
            this.Controls.Add(this.textBox_DSN);
            this.Controls.Add(this.textBox_UID);
            this.Controls.Add(this.button_Export);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.TextBox textBox_UID;
        private System.Windows.Forms.TextBox textBox_DSN;
        private System.Windows.Forms.TextBox textBox_DbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

