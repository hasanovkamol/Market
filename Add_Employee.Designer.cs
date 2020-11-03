namespace Market
{
    partial class Add_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Employee));
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.comPosition = new MetroFramework.Controls.MetroComboBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtAboutEmployees = new System.Windows.Forms.RichTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtPasportNumber = new MetroFramework.Controls.MetroTextBox();
            this.txtPhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.comCity = new MetroFramework.Controls.MetroComboBox();
            this.comCountry = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPhotoPath = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.HireDayEmployees = new MetroFramework.Controls.MetroDateTime();
            this.birthDayEmployees = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtlastname = new MetroFramework.Controls.MetroTextBox();
            this.txtFirstname = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lable = new MetroFramework.Controls.MetroLabel();
            this.txtPayment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(276, 134);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(41, 19);
            this.metroLabel13.TabIndex = 64;
            this.metroLabel13.Text = "Email";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(274, 157);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(239, 23);
            this.txtEmail.TabIndex = 63;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(275, 182);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(54, 19);
            this.metroLabel12.TabIndex = 62;
            this.metroLabel12.Text = "Position";
            // 
            // comPosition
            // 
            this.comPosition.FormattingEnabled = true;
            this.comPosition.ItemHeight = 23;
            this.comPosition.Location = new System.Drawing.Point(274, 206);
            this.comPosition.Name = "comPosition";
            this.comPosition.Size = new System.Drawing.Size(239, 29);
            this.comPosition.TabIndex = 61;
            this.comPosition.UseSelectable = true;
            this.comPosition.SelectedIndexChanged += new System.EventHandler(this.comPosition_SelectedIndexChanged);
            // 
            // metroButton3
            // 
            this.metroButton3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButton3.Location = new System.Drawing.Point(116, 495);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(93, 30);
            this.metroButton3.TabIndex = 60;
            this.metroButton3.Text = "Cancel";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.metroButton2.Location = new System.Drawing.Point(319, 495);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(93, 30);
            this.metroButton2.TabIndex = 59;
            this.metroButton2.Text = "Ok";
            this.metroButton2.UseSelectable = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(15, 397);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(132, 19);
            this.metroLabel11.TabIndex = 58;
            this.metroLabel11.Text = "The About Employee";
            // 
            // txtAboutEmployees
            // 
            this.txtAboutEmployees.Location = new System.Drawing.Point(15, 420);
            this.txtAboutEmployees.Name = "txtAboutEmployees";
            this.txtAboutEmployees.Size = new System.Drawing.Size(227, 52);
            this.txtAboutEmployees.TabIndex = 57;
            this.txtAboutEmployees.Text = "";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(275, 349);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(107, 19);
            this.metroLabel10.TabIndex = 56;
            this.metroLabel10.Text = "Pasport Number";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(15, 347);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(99, 19);
            this.metroLabel9.TabIndex = 55;
            this.metroLabel9.Text = "Phone Number";
            // 
            // txtPasportNumber
            // 
            // 
            // 
            // 
            this.txtPasportNumber.CustomButton.Image = null;
            this.txtPasportNumber.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtPasportNumber.CustomButton.Name = "";
            this.txtPasportNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPasportNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasportNumber.CustomButton.TabIndex = 1;
            this.txtPasportNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasportNumber.CustomButton.UseSelectable = true;
            this.txtPasportNumber.CustomButton.Visible = false;
            this.txtPasportNumber.Lines = new string[0];
            this.txtPasportNumber.Location = new System.Drawing.Point(274, 371);
            this.txtPasportNumber.MaxLength = 32767;
            this.txtPasportNumber.Name = "txtPasportNumber";
            this.txtPasportNumber.PasswordChar = '\0';
            this.txtPasportNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasportNumber.SelectedText = "";
            this.txtPasportNumber.SelectionLength = 0;
            this.txtPasportNumber.SelectionStart = 0;
            this.txtPasportNumber.ShortcutsEnabled = true;
            this.txtPasportNumber.Size = new System.Drawing.Size(239, 23);
            this.txtPasportNumber.TabIndex = 54;
            this.txtPasportNumber.UseSelectable = true;
            this.txtPasportNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasportNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhoneNumber
            // 
            // 
            // 
            // 
            this.txtPhoneNumber.CustomButton.Image = null;
            this.txtPhoneNumber.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.txtPhoneNumber.CustomButton.Name = "";
            this.txtPhoneNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhoneNumber.CustomButton.TabIndex = 1;
            this.txtPhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNumber.CustomButton.UseSelectable = true;
            this.txtPhoneNumber.CustomButton.Visible = false;
            this.txtPhoneNumber.Lines = new string[0];
            this.txtPhoneNumber.Location = new System.Drawing.Point(15, 370);
            this.txtPhoneNumber.MaxLength = 32767;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.ShortcutsEnabled = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(227, 23);
            this.txtPhoneNumber.TabIndex = 53;
            this.txtPhoneNumber.UseSelectable = true;
            this.txtPhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(275, 398);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(56, 19);
            this.metroLabel8.TabIndex = 52;
            this.metroLabel8.Text = "Address";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(275, 294);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(31, 19);
            this.metroLabel7.TabIndex = 51;
            this.metroLabel7.Text = "City";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(275, 238);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(56, 19);
            this.metroLabel6.TabIndex = 50;
            this.metroLabel6.Text = "Country";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(274, 420);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(239, 52);
            this.txtAddress.TabIndex = 49;
            this.txtAddress.Text = "";
            // 
            // comCity
            // 
            this.comCity.FormattingEnabled = true;
            this.comCity.ItemHeight = 23;
            this.comCity.Location = new System.Drawing.Point(274, 316);
            this.comCity.Name = "comCity";
            this.comCity.Size = new System.Drawing.Size(239, 29);
            this.comCity.TabIndex = 48;
            this.comCity.UseSelectable = true;
            // 
            // comCountry
            // 
            this.comCountry.FormattingEnabled = true;
            this.comCountry.ItemHeight = 23;
            this.comCountry.Location = new System.Drawing.Point(274, 261);
            this.comCountry.Name = "comCountry";
            this.comCountry.Size = new System.Drawing.Size(239, 29);
            this.comCountry.TabIndex = 47;
            this.comCountry.UseSelectable = true;
            this.comCountry.SelectedIndexChanged += new System.EventHandler(this.comCountry_SelectedIndexChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(15, 291);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 46;
            this.metroLabel5.Text = "HireDay";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 235);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 45;
            this.metroLabel4.Text = "BirthDay";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(276, 85);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 44;
            this.metroLabel3.Text = "PhotoPath";
            // 
            // txtPhotoPath
            // 
            // 
            // 
            // 
            this.txtPhotoPath.CustomButton.Image = null;
            this.txtPhotoPath.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtPhotoPath.CustomButton.Name = "";
            this.txtPhotoPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhotoPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhotoPath.CustomButton.TabIndex = 1;
            this.txtPhotoPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhotoPath.CustomButton.UseSelectable = true;
            this.txtPhotoPath.CustomButton.Visible = false;
            this.txtPhotoPath.Lines = new string[0];
            this.txtPhotoPath.Location = new System.Drawing.Point(274, 108);
            this.txtPhotoPath.MaxLength = 32767;
            this.txtPhotoPath.Name = "txtPhotoPath";
            this.txtPhotoPath.PasswordChar = '\0';
            this.txtPhotoPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhotoPath.SelectedText = "";
            this.txtPhotoPath.SelectionLength = 0;
            this.txtPhotoPath.SelectionStart = 0;
            this.txtPhotoPath.ShortcutsEnabled = true;
            this.txtPhotoPath.Size = new System.Drawing.Size(194, 23);
            this.txtPhotoPath.TabIndex = 43;
            this.txtPhotoPath.UseSelectable = true;
            this.txtPhotoPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhotoPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(475, 108);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(38, 23);
            this.metroButton1.TabIndex = 42;
            this.metroButton1.Text = "...";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // HireDayEmployees
            // 
            this.HireDayEmployees.Location = new System.Drawing.Point(15, 314);
            this.HireDayEmployees.MinimumSize = new System.Drawing.Size(0, 29);
            this.HireDayEmployees.Name = "HireDayEmployees";
            this.HireDayEmployees.Size = new System.Drawing.Size(227, 29);
            this.HireDayEmployees.TabIndex = 41;
            // 
            // birthDayEmployees
            // 
            this.birthDayEmployees.Location = new System.Drawing.Point(15, 258);
            this.birthDayEmployees.MinimumSize = new System.Drawing.Size(0, 29);
            this.birthDayEmployees.Name = "birthDayEmployees";
            this.birthDayEmployees.Size = new System.Drawing.Size(227, 29);
            this.birthDayEmployees.TabIndex = 40;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 185);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 39;
            this.metroLabel2.Text = "Last_name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 136);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 38;
            this.metroLabel1.Text = "First_name";
            // 
            // txtlastname
            // 
            // 
            // 
            // 
            this.txtlastname.CustomButton.Image = null;
            this.txtlastname.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.txtlastname.CustomButton.Name = "";
            this.txtlastname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtlastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtlastname.CustomButton.TabIndex = 1;
            this.txtlastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtlastname.CustomButton.UseSelectable = true;
            this.txtlastname.CustomButton.Visible = false;
            this.txtlastname.Lines = new string[0];
            this.txtlastname.Location = new System.Drawing.Point(15, 208);
            this.txtlastname.MaxLength = 32767;
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.PasswordChar = '\0';
            this.txtlastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtlastname.SelectedText = "";
            this.txtlastname.SelectionLength = 0;
            this.txtlastname.SelectionStart = 0;
            this.txtlastname.ShortcutsEnabled = true;
            this.txtlastname.Size = new System.Drawing.Size(227, 23);
            this.txtlastname.TabIndex = 37;
            this.txtlastname.UseSelectable = true;
            this.txtlastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtlastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFirstname
            // 
            // 
            // 
            // 
            this.txtFirstname.CustomButton.Image = null;
            this.txtFirstname.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.txtFirstname.CustomButton.Name = "";
            this.txtFirstname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstname.CustomButton.TabIndex = 1;
            this.txtFirstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstname.CustomButton.UseSelectable = true;
            this.txtFirstname.CustomButton.Visible = false;
            this.txtFirstname.Lines = new string[0];
            this.txtFirstname.Location = new System.Drawing.Point(15, 158);
            this.txtFirstname.MaxLength = 32767;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.PasswordChar = '\0';
            this.txtFirstname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstname.SelectedText = "";
            this.txtFirstname.SelectionLength = 0;
            this.txtFirstname.SelectionStart = 0;
            this.txtFirstname.ShortcutsEnabled = true;
            this.txtFirstname.Size = new System.Drawing.Size(227, 23);
            this.txtFirstname.TabIndex = 36;
            this.txtFirstname.UseSelectable = true;
            this.txtFirstname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(378, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(17, 85);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(202, 19);
            this.lable.TabIndex = 65;
            this.lable.Text = "Employee Month Payment Bonus";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(15, 108);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(227, 20);
            this.txtPayment.TabIndex = 66;
            // 
            // Add_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 546);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.comPosition);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.txtAboutEmployees);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtPasportNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.comCity);
            this.Controls.Add(this.comCountry);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtPhotoPath);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.HireDayEmployees);
            this.Controls.Add(this.birthDayEmployees);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Add_Employee";
            this.Text = "Add_Employee";
            this.Load += new System.EventHandler(this.Add_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroLabel metroLabel13;
        public MetroFramework.Controls.MetroTextBox txtEmail;
        public MetroFramework.Controls.MetroLabel metroLabel12;
        public MetroFramework.Controls.MetroComboBox comPosition;
        public MetroFramework.Controls.MetroButton metroButton3;
        public MetroFramework.Controls.MetroButton metroButton2;
        public MetroFramework.Controls.MetroLabel metroLabel11;
        public System.Windows.Forms.RichTextBox txtAboutEmployees;
        public MetroFramework.Controls.MetroLabel metroLabel10;
        public MetroFramework.Controls.MetroLabel metroLabel9;
        public MetroFramework.Controls.MetroTextBox txtPasportNumber;
        public MetroFramework.Controls.MetroTextBox txtPhoneNumber;
        public MetroFramework.Controls.MetroLabel metroLabel8;
        public MetroFramework.Controls.MetroLabel metroLabel7;
        public MetroFramework.Controls.MetroLabel metroLabel6;
        public System.Windows.Forms.RichTextBox txtAddress;
        public MetroFramework.Controls.MetroComboBox comCity;
        public MetroFramework.Controls.MetroComboBox comCountry;
        public MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTextBox txtPhotoPath;
        public MetroFramework.Controls.MetroButton metroButton1;
        public MetroFramework.Controls.MetroDateTime HireDayEmployees;
        public MetroFramework.Controls.MetroDateTime birthDayEmployees;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTextBox txtlastname;
        public MetroFramework.Controls.MetroTextBox txtFirstname;
        public System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroLabel lable;
        public System.Windows.Forms.TextBox txtPayment;
    }
}