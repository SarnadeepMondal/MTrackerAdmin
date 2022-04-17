namespace MTrackerDesktop
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drpOrgCity = new System.Windows.Forms.ComboBox();
            this.drpOrgState = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOrgGst = new System.Windows.Forms.TextBox();
            this.txtOrgZip = new System.Windows.Forms.TextBox();
            this.txtOrgAdd = new System.Windows.Forms.TextBox();
            this.txtOrgConPass = new System.Windows.Forms.TextBox();
            this.txtOrgCon = new System.Windows.Forms.TextBox();
            this.txtOrgPass = new System.Windows.Forms.TextBox();
            this.txtOrgEmail = new System.Windows.Forms.TextBox();
            this.txtOrgName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(113, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 31);
            this.button3.TabIndex = 49;
            this.button3.Text = "Go to Login";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 116);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // drpOrgCity
            // 
            this.drpOrgCity.FormattingEnabled = true;
            this.drpOrgCity.Items.AddRange(new object[] {
            "Asansol",
            "Durgapur"});
            this.drpOrgCity.Location = new System.Drawing.Point(541, 244);
            this.drpOrgCity.Name = "drpOrgCity";
            this.drpOrgCity.Size = new System.Drawing.Size(182, 28);
            this.drpOrgCity.TabIndex = 47;
            this.drpOrgCity.Text = "---Choose Option---";
            this.drpOrgCity.SelectedIndexChanged += new System.EventHandler(this.drpOrgCity_SelectedIndexChanged);
            // 
            // drpOrgState
            // 
            this.drpOrgState.FormattingEnabled = true;
            this.drpOrgState.Items.AddRange(new object[] {
            "West Bengal"});
            this.drpOrgState.Location = new System.Drawing.Point(541, 205);
            this.drpOrgState.Name = "drpOrgState";
            this.drpOrgState.Size = new System.Drawing.Size(182, 28);
            this.drpOrgState.TabIndex = 46;
            this.drpOrgState.Text = "---Choose Option---";
            this.drpOrgState.SelectedIndexChanged += new System.EventHandler(this.drpOrgState_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(339, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 31);
            this.button2.TabIndex = 45;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(580, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 31);
            this.button1.TabIndex = 44;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOrgGst
            // 
            this.txtOrgGst.Location = new System.Drawing.Point(542, 327);
            this.txtOrgGst.Name = "txtOrgGst";
            this.txtOrgGst.Size = new System.Drawing.Size(187, 27);
            this.txtOrgGst.TabIndex = 43;
            // 
            // txtOrgZip
            // 
            this.txtOrgZip.Location = new System.Drawing.Point(542, 284);
            this.txtOrgZip.Name = "txtOrgZip";
            this.txtOrgZip.Size = new System.Drawing.Size(187, 27);
            this.txtOrgZip.TabIndex = 42;
            // 
            // txtOrgAdd
            // 
            this.txtOrgAdd.Location = new System.Drawing.Point(539, 156);
            this.txtOrgAdd.Multiline = true;
            this.txtOrgAdd.Name = "txtOrgAdd";
            this.txtOrgAdd.Size = new System.Drawing.Size(187, 27);
            this.txtOrgAdd.TabIndex = 41;
            // 
            // txtOrgConPass
            // 
            this.txtOrgConPass.Location = new System.Drawing.Point(212, 330);
            this.txtOrgConPass.Name = "txtOrgConPass";
            this.txtOrgConPass.PasswordChar = '*';
            this.txtOrgConPass.Size = new System.Drawing.Size(187, 27);
            this.txtOrgConPass.TabIndex = 40;
            // 
            // txtOrgCon
            // 
            this.txtOrgCon.Location = new System.Drawing.Point(205, 200);
            this.txtOrgCon.Name = "txtOrgCon";
            this.txtOrgCon.Size = new System.Drawing.Size(187, 27);
            this.txtOrgCon.TabIndex = 39;
            // 
            // txtOrgPass
            // 
            this.txtOrgPass.Location = new System.Drawing.Point(209, 287);
            this.txtOrgPass.Name = "txtOrgPass";
            this.txtOrgPass.PasswordChar = '*';
            this.txtOrgPass.Size = new System.Drawing.Size(187, 27);
            this.txtOrgPass.TabIndex = 38;
            // 
            // txtOrgEmail
            // 
            this.txtOrgEmail.Location = new System.Drawing.Point(207, 244);
            this.txtOrgEmail.Name = "txtOrgEmail";
            this.txtOrgEmail.Size = new System.Drawing.Size(187, 27);
            this.txtOrgEmail.TabIndex = 37;
            // 
            // txtOrgName
            // 
            this.txtOrgName.Location = new System.Drawing.Point(204, 159);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(187, 27);
            this.txtOrgName.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Confirm Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "GST";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "ZIP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Org Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Org Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Org Name";
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.drpOrgCity);
            this.Controls.Add(this.drpOrgState);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOrgGst);
            this.Controls.Add(this.txtOrgZip);
            this.Controls.Add(this.txtOrgAdd);
            this.Controls.Add(this.txtOrgConPass);
            this.Controls.Add(this.txtOrgCon);
            this.Controls.Add(this.txtOrgPass);
            this.Controls.Add(this.txtOrgEmail);
            this.Controls.Add(this.txtOrgName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistration";
            this.Text = "frmRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button3;
        private PictureBox pictureBox1;
        private ComboBox drpOrgCity;
        private ComboBox drpOrgState;
        private Button button2;
        private Button button1;
        private TextBox txtOrgGst;
        private TextBox txtOrgZip;
        private TextBox txtOrgAdd;
        private TextBox txtOrgConPass;
        private TextBox txtOrgCon;
        private TextBox txtOrgPass;
        private TextBox txtOrgEmail;
        private TextBox txtOrgName;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}