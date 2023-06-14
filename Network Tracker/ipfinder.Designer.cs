
namespace Network_King
{
    partial class ipfinder
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.iptextBox = new System.Windows.Forms.TextBox();
            this.webaddressbutton = new System.Windows.Forms.Button();
            this.webaddresstextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.iptextBox);
            this.groupBox2.Controls.Add(this.webaddressbutton);
            this.groupBox2.Controls.Add(this.webaddresstextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 246);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IP Finder";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(203, 115);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Copy To Clipboard";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // iptextBox
            // 
            this.iptextBox.Location = new System.Drawing.Point(51, 112);
            this.iptextBox.Name = "iptextBox";
            this.iptextBox.ReadOnly = true;
            this.iptextBox.Size = new System.Drawing.Size(146, 20);
            this.iptextBox.TabIndex = 2;
            // 
            // webaddressbutton
            // 
            this.webaddressbutton.Location = new System.Drawing.Point(99, 180);
            this.webaddressbutton.Name = "webaddressbutton";
            this.webaddressbutton.Size = new System.Drawing.Size(118, 23);
            this.webaddressbutton.TabIndex = 4;
            this.webaddressbutton.Text = "Search Web Address IP";
            this.webaddressbutton.UseVisualStyleBackColor = true;
            this.webaddressbutton.Click += new System.EventHandler(this.webaddressbutton_Click);
            // 
            // webaddresstextBox
            // 
            this.webaddresstextBox.Location = new System.Drawing.Point(150, 45);
            this.webaddresstextBox.Name = "webaddresstextBox";
            this.webaddresstextBox.Size = new System.Drawing.Size(146, 20);
            this.webaddresstextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Web Address :=";
            // 
            // ipfinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 267);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ipfinder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Finder";
            this.Load += new System.EventHandler(this.ipfinder_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button webaddressbutton;
        private System.Windows.Forms.TextBox webaddresstextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox iptextBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}