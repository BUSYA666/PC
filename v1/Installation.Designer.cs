namespace PC
{
    partial class Installation
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
            this.DateDeinstalerBox = new System.Windows.Forms.ComboBox();
            this.DateInstallerBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.QuantityLicTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.NameUserTextBox = new System.Windows.Forms.TextBox();
            this.TableInstallation = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableInstallation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.DateDeinstalerBox);
            this.panel2.Controls.Add(this.DateInstallerBox);
            this.panel2.Controls.Add(this.AddButton);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.QuantityLicTextBox);
            this.panel2.Controls.Add(this.PriceTextBox);
            this.panel2.Controls.Add(this.NameUserTextBox);
            this.panel2.Controls.Add(this.TableInstallation);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 475);
            this.panel2.TabIndex = 16;
            // 
            // DateDeinstalerBox
            // 
            this.DateDeinstalerBox.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.DateDeinstalerBox.FormattingEnabled = true;
            this.DateDeinstalerBox.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.DateDeinstalerBox.Location = new System.Drawing.Point(565, 271);
            this.DateDeinstalerBox.Name = "DateDeinstalerBox";
            this.DateDeinstalerBox.Size = new System.Drawing.Size(199, 33);
            this.DateDeinstalerBox.TabIndex = 27;
            // 
            // DateInstallerBox
            // 
            this.DateInstallerBox.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.DateInstallerBox.FormattingEnabled = true;
            this.DateInstallerBox.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.DateInstallerBox.Location = new System.Drawing.Point(565, 224);
            this.DateInstallerBox.Name = "DateInstallerBox";
            this.DateInstallerBox.Size = new System.Drawing.Size(199, 33);
            this.DateInstallerBox.TabIndex = 26;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(518, 411);
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
            this.button1.Location = new System.Drawing.Point(348, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuantityLicTextBox
            // 
            this.QuantityLicTextBox.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.QuantityLicTextBox.Location = new System.Drawing.Point(565, 317);
            this.QuantityLicTextBox.Multiline = true;
            this.QuantityLicTextBox.Name = "QuantityLicTextBox";
            this.QuantityLicTextBox.Size = new System.Drawing.Size(199, 31);
            this.QuantityLicTextBox.TabIndex = 20;
            this.QuantityLicTextBox.Enter += new System.EventHandler(this.QuantityLicTextBox_Enter);
            this.QuantityLicTextBox.Leave += new System.EventHandler(this.QuantityLicTextBox_Leave);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.PriceTextBox.Location = new System.Drawing.Point(565, 166);
            this.PriceTextBox.Multiline = true;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(199, 31);
            this.PriceTextBox.TabIndex = 17;
            this.PriceTextBox.Enter += new System.EventHandler(this.PriceTextBox_Enter);
            this.PriceTextBox.Leave += new System.EventHandler(this.PriceTextBox_Leave);
            // 
            // NameUserTextBox
            // 
            this.NameUserTextBox.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.NameUserTextBox.Location = new System.Drawing.Point(565, 119);
            this.NameUserTextBox.Multiline = true;
            this.NameUserTextBox.Name = "NameUserTextBox";
            this.NameUserTextBox.Size = new System.Drawing.Size(199, 31);
            this.NameUserTextBox.TabIndex = 16;
            this.NameUserTextBox.Enter += new System.EventHandler(this.NameUserTextBox_Enter);
            this.NameUserTextBox.Leave += new System.EventHandler(this.NameUserTextBox_Leave);
            // 
            // TableInstallation
            // 
            this.TableInstallation.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.TableInstallation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableInstallation.Location = new System.Drawing.Point(12, 119);
            this.TableInstallation.Name = "TableInstallation";
            this.TableInstallation.Size = new System.Drawing.Size(547, 275);
            this.TableInstallation.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(164, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 41);
            this.button2.TabIndex = 14;
            this.button2.Text = "Главная";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 100);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(783, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(257, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Установка";
            // 
            // Installation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 475);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Installation";
            this.Text = "Installation";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableInstallation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView TableInstallation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameUserTextBox;
        private System.Windows.Forms.TextBox QuantityLicTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox DateDeinstalerBox;
        private System.Windows.Forms.ComboBox DateInstallerBox;
    }
}