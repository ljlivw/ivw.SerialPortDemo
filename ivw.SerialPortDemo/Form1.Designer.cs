namespace ivw.SerialPortDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.cbbPortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataBits = new System.Windows.Forms.TextBox();
            this.cbStopBits = new System.Windows.Forms.CheckBox();
            this.cbParity = new System.Windows.Forms.CheckBox();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(10, 8);
            this.rtbInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(286, 302);
            this.rtbInfo.TabIndex = 0;
            this.rtbInfo.Text = "";
            // 
            // cbbPortName
            // 
            this.cbbPortName.FormattingEnabled = true;
            this.cbbPortName.Location = new System.Drawing.Point(354, 8);
            this.cbbPortName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbPortName.Name = "cbbPortName";
            this.cbbPortName.Size = new System.Drawing.Size(86, 20);
            this.cbbPortName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "串口：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率：";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(498, 8);
            this.txtBaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(86, 21);
            this.txtBaudRate.TabIndex = 4;
            this.txtBaudRate.Text = "9600";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(589, 8);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(87, 21);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "波特率：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "数据位：";
            // 
            // txtDataBits
            // 
            this.txtDataBits.Location = new System.Drawing.Point(354, 30);
            this.txtDataBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(86, 21);
            this.txtDataBits.TabIndex = 4;
            this.txtDataBits.Text = "8";
            // 
            // cbStopBits
            // 
            this.cbStopBits.AutoSize = true;
            this.cbStopBits.Checked = true;
            this.cbStopBits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStopBits.Location = new System.Drawing.Point(445, 32);
            this.cbStopBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(60, 16);
            this.cbStopBits.TabIndex = 6;
            this.cbStopBits.Text = "停止位";
            this.cbStopBits.UseVisualStyleBackColor = true;
            // 
            // cbParity
            // 
            this.cbParity.AutoSize = true;
            this.cbParity.Location = new System.Drawing.Point(507, 32);
            this.cbParity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(84, 16);
            this.cbParity.TabIndex = 7;
            this.cbParity.Text = "奇偶校验位";
            this.cbParity.UseVisualStyleBackColor = true;
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(301, 293);
            this.txtWrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(283, 21);
            this.txtWrite.TabIndex = 8;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(589, 293);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(87, 21);
            this.btnWrite.TabIndex = 9;
            this.btnWrite.Text = "发送消息";
            this.btnWrite.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 318);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.cbStopBits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDataBits);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbPortName);
            this.Controls.Add(this.rtbInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口通信Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.ComboBox cbbPortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataBits;
        private System.Windows.Forms.CheckBox cbStopBits;
        private System.Windows.Forms.CheckBox cbParity;
        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.Button btnWrite;
    }
}

