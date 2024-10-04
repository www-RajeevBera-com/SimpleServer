
namespace SimpleServeGUI
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



        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBrowse = new Button();
            btnLaunch = new Button();
            txtPath = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPort = new TextBox();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(436, 43);
            btnBrowse.Margin = new Padding(4, 3, 4, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(88, 27);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnLaunch
            // 
            btnLaunch.Location = new Point(436, 108);
            btnLaunch.Margin = new Padding(4, 3, 4, 3);
            btnLaunch.Name = "btnLaunch";
            btnLaunch.Size = new Size(88, 27);
            btnLaunch.TabIndex = 1;
            btnLaunch.Text = "Launch";
            btnLaunch.UseVisualStyleBackColor = true;
            btnLaunch.Click += btnLaunch_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(111, 45);
            txtPath.Margin = new Padding(4, 3, 4, 3);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(318, 23);
            txtPath.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Site Path:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 114);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 5;
            label2.Text = "Port:";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(111, 111);
            txtPort.Margin = new Padding(4, 3, 4, 3);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(318, 23);
            txtPort.TabIndex = 4;
            txtPort.Text = "8080";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 186);
            Controls.Add(label2);
            Controls.Add(txtPort);
            Controls.Add(label1);
            Controls.Add(txtPath);
            Controls.Add(btnLaunch);
            Controls.Add(btnBrowse);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Simple Web Server";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
    }
}
