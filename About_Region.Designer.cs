namespace Market
{
    partial class About_Region
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.txtCityname = new MetroFramework.Controls.MetroTextBox();
            this.txtSelectCountryname = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCountry_name = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.metroButton2);
            this.groupBox2.Controls.Add(this.txtCityname);
            this.groupBox2.Controls.Add(this.txtSelectCountryname);
            this.groupBox2.Location = new System.Drawing.Point(254, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 165);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "City Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Country Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(149, 125);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(65, 34);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "save";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // txtCityname
            // 
            // 
            // 
            // 
            this.txtCityname.CustomButton.Image = null;
            this.txtCityname.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txtCityname.CustomButton.Name = "";
            this.txtCityname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCityname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCityname.CustomButton.TabIndex = 1;
            this.txtCityname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCityname.CustomButton.UseSelectable = true;
            this.txtCityname.CustomButton.Visible = false;
            this.txtCityname.Lines = new string[0];
            this.txtCityname.Location = new System.Drawing.Point(19, 96);
            this.txtCityname.MaxLength = 32767;
            this.txtCityname.Name = "txtCityname";
            this.txtCityname.PasswordChar = '\0';
            this.txtCityname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCityname.SelectedText = "";
            this.txtCityname.SelectionLength = 0;
            this.txtCityname.SelectionStart = 0;
            this.txtCityname.ShortcutsEnabled = true;
            this.txtCityname.Size = new System.Drawing.Size(195, 23);
            this.txtCityname.TabIndex = 1;
            this.txtCityname.UseSelectable = true;
            this.txtCityname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCityname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSelectCountryname
            // 
            this.txtSelectCountryname.FormattingEnabled = true;
            this.txtSelectCountryname.ItemHeight = 23;
            this.txtSelectCountryname.Location = new System.Drawing.Point(19, 41);
            this.txtSelectCountryname.Name = "txtSelectCountryname";
            this.txtSelectCountryname.Size = new System.Drawing.Size(195, 29);
            this.txtSelectCountryname.TabIndex = 0;
            this.txtSelectCountryname.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCountry_name);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Country";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(19, 98);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(84, 23);
            this.txtID.TabIndex = 4;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(148, 125);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(63, 34);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "save";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country Code";
            // 
            // txtCountry_name
            // 
            // 
            // 
            // 
            this.txtCountry_name.CustomButton.Image = null;
            this.txtCountry_name.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtCountry_name.CustomButton.Name = "";
            this.txtCountry_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCountry_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCountry_name.CustomButton.TabIndex = 1;
            this.txtCountry_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCountry_name.CustomButton.UseSelectable = true;
            this.txtCountry_name.CustomButton.Visible = false;
            this.txtCountry_name.Lines = new string[0];
            this.txtCountry_name.Location = new System.Drawing.Point(19, 45);
            this.txtCountry_name.MaxLength = 32767;
            this.txtCountry_name.Name = "txtCountry_name";
            this.txtCountry_name.PasswordChar = '\0';
            this.txtCountry_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCountry_name.SelectedText = "";
            this.txtCountry_name.SelectionLength = 0;
            this.txtCountry_name.SelectionStart = 0;
            this.txtCountry_name.ShortcutsEnabled = true;
            this.txtCountry_name.Size = new System.Drawing.Size(192, 29);
            this.txtCountry_name.TabIndex = 6;
            this.txtCountry_name.UseSelectable = true;
            this.txtCountry_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCountry_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Country Name";
            // 
            // About_Region
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 198);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "About_Region";
            this.Text = "About_Region";
            this.Load += new System.EventHandler(this.About_Region_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox txtCityname;
        private MetroFramework.Controls.MetroComboBox txtSelectCountryname;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtCountry_name;
    }
}