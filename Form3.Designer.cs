namespace WinFormsApp1
{
    partial class Admin_Datagrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Datagrid));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            ADMIN_IDTXT = new TextBox();
            PasswordTxt = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(337, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(602, 428);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Papyrus", 8F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(337, 489);
            button1.Name = "button1";
            button1.Size = new Size(146, 64);
            button1.TabIndex = 1;
            button1.Text = "POPULATE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Papyrus", 8F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(531, 489);
            button2.Name = "button2";
            button2.Size = new Size(151, 64);
            button2.TabIndex = 2;
            button2.Text = " CLOSE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 3;
            label1.Text = "ADMIN-ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 264);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 4;
            label2.Text = "PASSWORD";
            // 
            // ADMIN_IDTXT
            // 
            ADMIN_IDTXT.Location = new Point(165, 75);
            ADMIN_IDTXT.Name = "ADMIN_IDTXT";
            ADMIN_IDTXT.Size = new Size(150, 31);
            ADMIN_IDTXT.TabIndex = 5;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Location = new Point(165, 258);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(150, 31);
            PasswordTxt.TabIndex = 6;
            PasswordTxt.UseSystemPasswordChar = true;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Papyrus", 8F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(163, 489);
            button3.Name = "button3";
            button3.Size = new Size(128, 64);
            button3.TabIndex = 7;
            button3.Text = "<<BACK\r\n";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Admin_Datagrid
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(951, 574);
            Controls.Add(button3);
            Controls.Add(PasswordTxt);
            Controls.Add(ADMIN_IDTXT);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Admin_Datagrid";
            Text = "Admin-Datagrid View";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox ADMIN_IDTXT;
        private TextBox PasswordTxt;
        private Button button3;
    }
}