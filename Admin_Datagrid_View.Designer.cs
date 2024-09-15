namespace WinFormsApp1
{
    partial class Admin_Datagrid_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Datagrid_View));
            dataGridView1 = new DataGridView();
            PopulateBut = new Button();
            CloseBut = new Button();
            AdminLbel = new Label();
            Password = new Label();
            AdmTxt = new TextBox();
            PassTxt = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SlateGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(388, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(562, 513);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // PopulateBut
            // 
            PopulateBut.BackColor = SystemColors.ActiveCaptionText;
            PopulateBut.Font = new Font("Papyrus", 8F, FontStyle.Bold);
            PopulateBut.ForeColor = SystemColors.ControlLightLight;
            PopulateBut.Location = new Point(343, 536);
            PopulateBut.Name = "PopulateBut";
            PopulateBut.Size = new Size(169, 64);
            PopulateBut.TabIndex = 1;
            PopulateBut.Text = "POPULATE";
            PopulateBut.UseVisualStyleBackColor = false;
            PopulateBut.Click += button1_Click;
            // 
            // CloseBut
            // 
            CloseBut.BackColor = SystemColors.ActiveCaptionText;
            CloseBut.Font = new Font("Papyrus", 8F, FontStyle.Bold);
            CloseBut.ForeColor = SystemColors.ButtonHighlight;
            CloseBut.Location = new Point(544, 536);
            CloseBut.Name = "CloseBut";
            CloseBut.Size = new Size(174, 64);
            CloseBut.TabIndex = 2;
            CloseBut.Text = "CLOSE";
            CloseBut.UseVisualStyleBackColor = false;
            CloseBut.Click += CloseBut_Click;
            // 
            // AdminLbel
            // 
            AdminLbel.AutoSize = true;
            AdminLbel.BackColor = SystemColors.ActiveCaptionText;
            AdminLbel.ForeColor = SystemColors.ControlLightLight;
            AdminLbel.Location = new Point(12, 83);
            AdminLbel.Name = "AdminLbel";
            AdminLbel.Size = new Size(96, 25);
            AdminLbel.TabIndex = 3;
            AdminLbel.Text = "ADMIN-ID";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = SystemColors.ActiveCaptionText;
            Password.ForeColor = SystemColors.ControlLightLight;
            Password.Location = new Point(12, 285);
            Password.Name = "Password";
            Password.Size = new Size(108, 25);
            Password.TabIndex = 4;
            Password.Text = "PASSWORD";
            // 
            // AdmTxt
            // 
            AdmTxt.Location = new Point(211, 77);
            AdmTxt.Name = "AdmTxt";
            AdmTxt.Size = new Size(150, 31);
            AdmTxt.TabIndex = 5;
            // 
            // PassTxt
            // 
            PassTxt.Location = new Point(211, 279);
            PassTxt.Name = "PassTxt";
            PassTxt.Size = new Size(150, 31);
            PassTxt.TabIndex = 6;
            PassTxt.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Papyrus", 8F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(164, 536);
            button1.Name = "button1";
            button1.Size = new Size(139, 64);
            button1.TabIndex = 7;
            button1.Text = "<< BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Admin_Datagrid_View
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(954, 612);
            Controls.Add(button1);
            Controls.Add(PassTxt);
            Controls.Add(AdmTxt);
            Controls.Add(Password);
            Controls.Add(AdminLbel);
            Controls.Add(CloseBut);
            Controls.Add(PopulateBut);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "Admin_Datagrid_View";
            Text = "Admin_Datagrid_View";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button PopulateBut;
        private Button CloseBut;
        private Label AdminLbel;
        private Label Password;
        private TextBox AdmTxt;
        private TextBox PassTxt;
        private Button button1;
    }
}