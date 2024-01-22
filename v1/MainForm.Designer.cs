namespace Theater
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SoftwareButton = new System.Windows.Forms.Button();
            this.InstallationButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 100);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(344, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(112, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Главная";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.SoftwareButton);
            this.panel2.Controls.Add(this.InstallationButton);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 400);
            this.panel2.TabIndex = 14;
            // 
            // SoftwareButton
            // 
            this.SoftwareButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.SoftwareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SoftwareButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SoftwareButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SoftwareButton.Location = new System.Drawing.Point(65, 269);
            this.SoftwareButton.Name = "SoftwareButton";
            this.SoftwareButton.Size = new System.Drawing.Size(242, 61);
            this.SoftwareButton.TabIndex = 16;
            this.SoftwareButton.Text = "Программное \r\nобеспечение";
            this.SoftwareButton.UseVisualStyleBackColor = false;
            this.SoftwareButton.Click += new System.EventHandler(this.SoftwareButton_Click);
            // 
            // InstallationButton
            // 
            this.InstallationButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.InstallationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallationButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstallationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InstallationButton.Location = new System.Drawing.Point(74, 196);
            this.InstallationButton.Name = "InstallationButton";
            this.InstallationButton.Size = new System.Drawing.Size(221, 48);
            this.InstallationButton.TabIndex = 15;
            this.InstallationButton.Text = "Установка";
            this.InstallationButton.UseVisualStyleBackColor = false;
            this.InstallationButton.Click += new System.EventHandler(this.InstallationButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(74, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 48);
            this.button2.TabIndex = 14;
            this.button2.Text = "Выборки";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 400);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SoftwareButton;
        private System.Windows.Forms.Button InstallationButton;
    }
}