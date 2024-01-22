namespace PC
{
    partial class Software
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.FirmTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AppliedTextBox = new System.Windows.Forms.TextBox();
            this.VersionTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TableSoftware = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TableSample = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableSoftware)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableSample)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.TableSample);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 486);
            this.panel2.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.PriceTextBox);
            this.panel4.Controls.Add(this.DateTextBox);
            this.panel4.Controls.Add(this.FirmTextBox);
            this.panel4.Controls.Add(this.TypeTextBox);
            this.panel4.Controls.Add(this.AddButton);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.AppliedTextBox);
            this.panel4.Controls.Add(this.VersionTextBox);
            this.panel4.Controls.Add(this.NameTextBox);
            this.panel4.Controls.Add(this.TableSoftware);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(941, 486);
            this.panel4.TabIndex = 17;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PriceTextBox.Location = new System.Drawing.Point(781, 376);
            this.PriceTextBox.Multiline = true;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(148, 31);
            this.PriceTextBox.TabIndex = 26;
            this.PriceTextBox.Enter += new System.EventHandler(this.PriceTextBox_Enter);
            this.PriceTextBox.Leave += new System.EventHandler(this.PriceTextBox_Leave);
            // 
            // DateTextBox
            // 
            this.DateTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.DateTextBox.Location = new System.Drawing.Point(781, 284);
            this.DateTextBox.Multiline = true;
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(148, 31);
            this.DateTextBox.TabIndex = 25;
            this.DateTextBox.Enter += new System.EventHandler(this.DateTextBox_Enter);
            this.DateTextBox.Leave += new System.EventHandler(this.DateTextBox_Leave);
            // 
            // FirmTextBox
            // 
            this.FirmTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FirmTextBox.Location = new System.Drawing.Point(781, 247);
            this.FirmTextBox.Multiline = true;
            this.FirmTextBox.Name = "FirmTextBox";
            this.FirmTextBox.Size = new System.Drawing.Size(148, 31);
            this.FirmTextBox.TabIndex = 24;
            this.FirmTextBox.Enter += new System.EventHandler(this.FirmTextBox_Enter);
            this.FirmTextBox.Leave += new System.EventHandler(this.FirmTextBox_Leave);
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TypeTextBox.Location = new System.Drawing.Point(781, 210);
            this.TypeTextBox.Multiline = true;
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(148, 31);
            this.TypeTextBox.TabIndex = 23;
            this.TypeTextBox.Enter += new System.EventHandler(this.TypeTextBox_Enter);
            this.TypeTextBox.Leave += new System.EventHandler(this.TypeTextBox_Leave);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(521, 426);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 41);
            this.AddButton.TabIndex = 22;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(351, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AppliedTextBox
            // 
            this.AppliedTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.AppliedTextBox.Location = new System.Drawing.Point(781, 321);
            this.AppliedTextBox.Multiline = true;
            this.AppliedTextBox.Name = "AppliedTextBox";
            this.AppliedTextBox.Size = new System.Drawing.Size(148, 49);
            this.AppliedTextBox.TabIndex = 20;
            this.AppliedTextBox.Enter += new System.EventHandler(this.AppliedTextBox_Enter);
            this.AppliedTextBox.Leave += new System.EventHandler(this.AppliedTextBox_Leave);
            // 
            // VersionTextBox
            // 
            this.VersionTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.VersionTextBox.Location = new System.Drawing.Point(781, 173);
            this.VersionTextBox.Multiline = true;
            this.VersionTextBox.Name = "VersionTextBox";
            this.VersionTextBox.Size = new System.Drawing.Size(148, 31);
            this.VersionTextBox.TabIndex = 17;
            this.VersionTextBox.Enter += new System.EventHandler(this.VersionTextBox_Enter);
            this.VersionTextBox.Leave += new System.EventHandler(this.VersionTextBox_Leave);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(781, 136);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(148, 31);
            this.NameTextBox.TabIndex = 16;
            this.NameTextBox.Enter += new System.EventHandler(this.NameTextBox_Enter);
            this.NameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // TableSoftware
            // 
            this.TableSoftware.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.TableSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableSoftware.Location = new System.Drawing.Point(12, 106);
            this.TableSoftware.Name = "TableSoftware";
            this.TableSoftware.Size = new System.Drawing.Size(763, 301);
            this.TableSoftware.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(167, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 41);
            this.button3.TabIndex = 14;
            this.button3.Text = "Главная";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(941, 100);
            this.panel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(922, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(203, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(470, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "Программное обеспечения";
            // 
            // TableSample
            // 
            this.TableSample.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.TableSample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableSample.Location = new System.Drawing.Point(12, 106);
            this.TableSample.Name = "TableSample";
            this.TableSample.Size = new System.Drawing.Size(301, 234);
            this.TableSample.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(341, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 41);
            this.button2.TabIndex = 14;
            this.button2.Text = "Главная";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 100);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(492, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(64, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Определить прикладную область,\r\n которая требует наибольшей\r\n номенклатуры програ" +
    "ммных продуктов. ";
            // 
            // Software
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 486);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Software";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableSoftware)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableSample)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView TableSample;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox FirmTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AppliedTextBox;
        private System.Windows.Forms.TextBox VersionTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.DataGridView TableSoftware;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceTextBox;
    }
}