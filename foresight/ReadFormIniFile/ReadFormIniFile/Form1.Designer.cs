namespace ReadFormIniFile
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.test1 = new System.Windows.Forms.TabPage();
            this.test2 = new System.Windows.Forms.TabPage();
            this.inivalue = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.test1.SuspendLayout();
            this.test2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(309, 181);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(405, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 184);
            this.listBox1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.test1);
            this.tabControl1.Controls.Add(this.test2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 296);
            this.tabControl1.TabIndex = 3;
            // 
            // test1
            // 
            this.test1.Controls.Add(this.listBox1);
            this.test1.Controls.Add(this.button1);
            this.test1.Controls.Add(this.textBox1);
            this.test1.Location = new System.Drawing.Point(4, 22);
            this.test1.Name = "test1";
            this.test1.Padding = new System.Windows.Forms.Padding(3);
            this.test1.Size = new System.Drawing.Size(801, 270);
            this.test1.TabIndex = 0;
            this.test1.Text = "StreamReader讀ini";
            this.test1.UseVisualStyleBackColor = true;
            // 
            // test2
            // 
            this.test2.Controls.Add(this.button2);
            this.test2.Controls.Add(this.inivalue);
            this.test2.Location = new System.Drawing.Point(4, 22);
            this.test2.Name = "test2";
            this.test2.Padding = new System.Windows.Forms.Padding(3);
            this.test2.Size = new System.Drawing.Size(801, 270);
            this.test2.TabIndex = 1;
            this.test2.Text = "調用API";
            this.test2.UseVisualStyleBackColor = true;
            // 
            // inivalue
            // 
            this.inivalue.Location = new System.Drawing.Point(70, 37);
            this.inivalue.Name = "inivalue";
            this.inivalue.Size = new System.Drawing.Size(208, 22);
            this.inivalue.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 320);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.test1.ResumeLayout(false);
            this.test1.PerformLayout();
            this.test2.ResumeLayout(false);
            this.test2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage test1;
        private System.Windows.Forms.TabPage test2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inivalue;
    }
}

