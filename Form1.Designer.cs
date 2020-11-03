namespace Market
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCreate = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.txtSearchItems = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(558, 244);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtCreate
            // 
            this.txtCreate.ActiveControl = null;
            this.txtCreate.Location = new System.Drawing.Point(34, 345);
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(102, 54);
            this.txtCreate.TabIndex = 8;
            this.txtCreate.Text = "Create";
            this.txtCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtCreate.UseSelectable = true;
            this.txtCreate.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(148, 345);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(102, 54);
            this.metroTile2.TabIndex = 9;
            this.metroTile2.Text = "View";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(262, 345);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(102, 54);
            this.metroTile3.TabIndex = 10;
            this.metroTile3.Text = "Update";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(376, 345);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(102, 54);
            this.metroTile4.TabIndex = 11;
            this.metroTile4.Text = "Delete";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(490, 345);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(102, 54);
            this.metroTile5.TabIndex = 12;
            this.metroTile5.Text = "Print";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Employee",
            "Account",
            "Position",
            "Region",
            "Product",
            "Categories",
            "Deliver"});
            this.metroComboBox1.Location = new System.Drawing.Point(34, 46);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(216, 29);
            this.metroComboBox1.TabIndex = 15;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // txtSearchItems
            // 
            // 
            // 
            // 
            this.txtSearchItems.CustomButton.Image = null;
            this.txtSearchItems.CustomButton.Location = new System.Drawing.Point(308, 1);
            this.txtSearchItems.CustomButton.Name = "";
            this.txtSearchItems.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchItems.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchItems.CustomButton.TabIndex = 1;
            this.txtSearchItems.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchItems.CustomButton.UseSelectable = true;
            this.txtSearchItems.CustomButton.Visible = false;
            this.txtSearchItems.Lines = new string[] {
        "Search"};
            this.txtSearchItems.Location = new System.Drawing.Point(262, 46);
            this.txtSearchItems.MaxLength = 32767;
            this.txtSearchItems.Name = "txtSearchItems";
            this.txtSearchItems.PasswordChar = '\0';
            this.txtSearchItems.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchItems.SelectedText = "";
            this.txtSearchItems.SelectionLength = 0;
            this.txtSearchItems.SelectionStart = 0;
            this.txtSearchItems.ShortcutsEnabled = true;
            this.txtSearchItems.Size = new System.Drawing.Size(330, 23);
            this.txtSearchItems.TabIndex = 16;
            this.txtSearchItems.Text = "Search";
            this.txtSearchItems.UseSelectable = true;
            this.txtSearchItems.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchItems.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearchItems);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.txtCreate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTile txtCreate;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox txtSearchItems;
        private System.Windows.Forms.Button button1;
    }
}

