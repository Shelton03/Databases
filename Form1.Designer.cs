namespace WinFormsApp1
{
    partial class Students_Registration : Form
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students_Registration));
            label1 = new Label();
            Firsttxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Lasttxt = new TextBox();
            DOBTxt = new TextBox();
            GenderTxt = new TextBox();
            IDTxt = new TextBox();
            ProgrammeTxt = new TextBox();
            Submit_Button = new Button();
            closeBut = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 52);
            label1.MaximumSize = new Size(500, 500);
            label1.MinimumSize = new Size(99, 25);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 0;
            label1.Text = "First-Name";
            // 
            // Firsttxt
            // 
            Firsttxt.Location = new Point(438, 46);
            Firsttxt.Name = "Firsttxt";
            Firsttxt.Size = new Size(241, 31);
            Firsttxt.TabIndex = 1;
            Firsttxt.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 108);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 2;
            label2.Text = "Last-Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 172);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 3;
            label3.Text = "D.O.B";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 234);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 4;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 298);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 5;
            label5.Text = "ID-Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 368);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 6;
            label6.Text = "Programme";
            // 
            // Lasttxt
            // 
            Lasttxt.Location = new Point(438, 102);
            Lasttxt.Name = "Lasttxt";
            Lasttxt.Size = new Size(241, 31);
            Lasttxt.TabIndex = 7;
            // 
            // DOBTxt
            // 
            DOBTxt.Location = new Point(438, 166);
            DOBTxt.Name = "DOBTxt";
            DOBTxt.PlaceholderText = "Format: yyyy-mm-dd";
            DOBTxt.Size = new Size(241, 31);
            DOBTxt.TabIndex = 8;
            // 
            // GenderTxt
            // 
            GenderTxt.Location = new Point(438, 228);
            GenderTxt.Name = "GenderTxt";
            GenderTxt.Size = new Size(241, 31);
            GenderTxt.TabIndex = 9;
            // 
            // IDTxt
            // 
            IDTxt.Location = new Point(438, 292);
            IDTxt.Name = "IDTxt";
            IDTxt.PlaceholderText = "Example:23456-8765-C20";
            IDTxt.Size = new Size(241, 31);
            IDTxt.TabIndex = 10;
            // 
            // ProgrammeTxt
            // 
            ProgrammeTxt.Location = new Point(438, 362);
            ProgrammeTxt.Name = "ProgrammeTxt";
            ProgrammeTxt.Size = new Size(241, 31);
            ProgrammeTxt.TabIndex = 11;
            // 
            // Submit_Button
            // 
            Submit_Button.BackColor = SystemColors.InfoText;
            Submit_Button.ForeColor = SystemColors.ButtonHighlight;
            Submit_Button.Location = new Point(292, 439);
            Submit_Button.Name = "Submit_Button";
            Submit_Button.Size = new Size(112, 61);
            Submit_Button.TabIndex = 12;
            Submit_Button.Text = "SUBMIT";
            Submit_Button.UseVisualStyleBackColor = false;
            Submit_Button.Click += Submit_Button_Click;
            // 
            // closeBut
            // 
            closeBut.BackColor = SystemColors.ControlText;
            closeBut.ForeColor = SystemColors.ControlLightLight;
            closeBut.Location = new Point(292, 506);
            closeBut.Name = "closeBut";
            closeBut.Size = new Size(112, 34);
            closeBut.TabIndex = 13;
            closeBut.Text = "CLOSE";
            closeBut.UseVisualStyleBackColor = false;
            closeBut.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(115, 439);
            button1.Name = "button1";
            button1.Size = new Size(147, 61);
            button1.TabIndex = 14;
            button1.Text = "Admin-View\r\n(QUERY)\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(438, 439);
            button2.Name = "button2";
            button2.Size = new Size(132, 61);
            button2.TabIndex = 15;
            button2.Text = "Admin-View\r\n(DataBinding)";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Students_Registration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(691, 546);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(closeBut);
            Controls.Add(Submit_Button);
            Controls.Add(ProgrammeTxt);
            Controls.Add(IDTxt);
            Controls.Add(GenderTxt);
            Controls.Add(DOBTxt);
            Controls.Add(Lasttxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Firsttxt);
            Controls.Add(label1);
            Name = "Students_Registration";
            Text = "Students-Registration";
            Load += Students_Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Firsttxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Lasttxt;
        private TextBox DOBTxt;
        private TextBox GenderTxt;
        private TextBox IDTxt;
        private TextBox ProgrammeTxt;
        private Button Submit_Button;
        private Button closeBut;
        private Button button1;
        private Button button2;
    }
}
