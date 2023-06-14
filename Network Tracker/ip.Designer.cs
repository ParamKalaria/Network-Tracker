
namespace Network_King
{
    partial class ip
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gatewaytextBox = new System.Windows.Forms.TextBox();
            this.externaliptextBox = new System.Windows.Forms.TextBox();
            this.localiptextBox = new System.Windows.Forms.TextBox();
            this.computernametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.gatewaytextBox);
            this.groupBox1.Controls.Add(this.externaliptextBox);
            this.groupBox1.Controls.Add(this.localiptextBox);
            this.groupBox1.Controls.Add(this.computernametextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP\'s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gateway Address :=";
            // 
            // gatewaytextBox
            // 
            this.gatewaytextBox.Location = new System.Drawing.Point(162, 193);
            this.gatewaytextBox.Name = "gatewaytextBox";
            this.gatewaytextBox.ReadOnly = true;
            this.gatewaytextBox.Size = new System.Drawing.Size(146, 20);
            this.gatewaytextBox.TabIndex = 4;
            // 
            // externaliptextBox
            // 
            this.externaliptextBox.Location = new System.Drawing.Point(162, 142);
            this.externaliptextBox.Name = "externaliptextBox";
            this.externaliptextBox.ReadOnly = true;
            this.externaliptextBox.Size = new System.Drawing.Size(146, 20);
            this.externaliptextBox.TabIndex = 3;
            // 
            // localiptextBox
            // 
            this.localiptextBox.Location = new System.Drawing.Point(162, 91);
            this.localiptextBox.Name = "localiptextBox";
            this.localiptextBox.ReadOnly = true;
            this.localiptextBox.Size = new System.Drawing.Size(146, 20);
            this.localiptextBox.TabIndex = 2;
            // 
            // computernametextBox
            // 
            this.computernametextBox.Location = new System.Drawing.Point(162, 42);
            this.computernametextBox.Name = "computernametextBox";
            this.computernametextBox.ReadOnly = true;
            this.computernametextBox.Size = new System.Drawing.Size(146, 20);
            this.computernametextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "External IP :=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local IP:=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Computer Name :=";
            // 
            // ip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 267);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ip";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ip";
            this.Load += new System.EventHandler(this.ip_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gatewaytextBox;
        private System.Windows.Forms.TextBox externaliptextBox;
        private System.Windows.Forms.TextBox localiptextBox;
        private System.Windows.Forms.TextBox computernametextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}